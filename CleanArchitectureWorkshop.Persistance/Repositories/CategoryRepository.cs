using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Domain.Entities;
using FirstRowTickets.TicketManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FirstRowTicketsDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
          
                var allCategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
                if (!includePassedEvents)
                {
                    allCategories.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date <
                   DateTime.Today));
                }
                return allCategories;
            
        }
    }
}
