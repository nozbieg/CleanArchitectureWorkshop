using AutoMapper;
using CleanArchitectureWorkshop.Application.Features.Events.Queries;
using CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventDetails;
using CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventsList;
using CleanArchitectureWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event, EventsListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryDto>().ReverseMap();
        }
    }
}
