using System;

namespace CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventsList
{
    public class EventsListVm
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
