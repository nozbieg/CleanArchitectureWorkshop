using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            throw new NotImplementedException();
        }
    }
}
