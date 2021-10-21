using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        readonly IEventRepository _eventRepository;

        public CreateEventCommandValidator(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters")
                .NotNull();

            RuleFor(p => p.Date)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .GreaterThan(DateTime.Now)
               .NotNull();

            RuleFor(p => p.Price)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .GreaterThan(0);

            RuleFor(e => e)
              .MustAsync(EventNameAndDateUnique).WithMessage("An event with the same name and date already exists.");

        }
        private async Task<bool> EventNameAndDateUnique(CreateEventCommand e, CancellationToken token)
        {
            return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
        }


    }
}
