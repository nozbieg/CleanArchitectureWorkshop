using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventDetail
{
   public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid EventId { get; set; }
    }
}
