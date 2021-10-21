﻿using AutoMapper;
using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        readonly IMapper _mapper;
        readonly IAsyncRepository<Event> _eventRepository;
        readonly IAsyncRepository<Category> _categoryRepository;
        public GetEventDetailQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
        }

        public Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
