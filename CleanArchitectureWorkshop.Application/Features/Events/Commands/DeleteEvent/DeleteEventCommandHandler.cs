using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, Guid>
    {
        public Task<Guid> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
