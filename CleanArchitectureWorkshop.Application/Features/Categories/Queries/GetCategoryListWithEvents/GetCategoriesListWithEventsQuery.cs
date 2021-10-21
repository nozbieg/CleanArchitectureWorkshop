using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
   public  class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
    }
}
