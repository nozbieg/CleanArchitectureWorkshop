using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Commands.UpdateEvent
{
   public class UpdateEventCommandValidator : AbstractValidator<UpdateEventCommand>
    {
        public UpdateEventCommandValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters")
               .NotNull();

            RuleFor(p => p.Date)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .GreaterThan(DateTime.Now)
               .NotNull();
        }
    }
}
