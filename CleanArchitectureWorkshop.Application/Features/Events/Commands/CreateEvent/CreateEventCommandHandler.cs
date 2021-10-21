using AutoMapper;
using CleanArchitectureWorkshop.Application.Contracts.Infrastructure;
using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Application.Models.Mail;
using CleanArchitectureWorkshop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        readonly IEventRepository _eventRepository;
        readonly IMapper _mapper;
        readonly IEmailService _emailService;

        public CreateEventCommandHandler(IEventRepository eventRepository, IMapper mapper, IEmailService emailService)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _emailService = emailService;
        }
        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);

            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            @event = await _eventRepository.AddAsync(@event);


            var email = new Email()
            {
                To = "gill@snowball.be",
                Body = $"A new eventwas created: { request}",
                Subject = "A new event was created" };
            try
            {
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {

            }
            return @event.EventId;
        }
    }
}
