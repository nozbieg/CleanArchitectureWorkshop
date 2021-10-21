using CleanArchitectureWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Contracts.Persistance
{
    public interface IEventRepository: IAsyncRepository<Event>
    {
    }
}
