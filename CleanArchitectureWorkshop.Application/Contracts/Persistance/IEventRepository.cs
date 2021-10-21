using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Contracts.Persistance
{
    public interface IEventRepository<T> where T : class
    {
    }
}
