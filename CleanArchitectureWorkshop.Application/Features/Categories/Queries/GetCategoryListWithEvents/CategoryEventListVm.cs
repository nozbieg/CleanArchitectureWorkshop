using System;
using System.Collections.Generic;

namespace CleanArchitectureWorkshop.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class CategoryEventListVm
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<CategoryEventDto> Events { get; set; }
    }
}
