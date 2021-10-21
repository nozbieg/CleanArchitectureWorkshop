using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Persistance.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            throw new NotImplementedException();
        }
    }
}
