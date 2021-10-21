using AutoMapper;
using CleanArchitectureWorkshop.Application.Features.Categories.Queries.GetCategoryList;
using CleanArchitectureWorkshop.Application.Features.Categories.Queries.GetCategoryListWithEvents;
using CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventDetail;
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
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();
        }
    }
}
