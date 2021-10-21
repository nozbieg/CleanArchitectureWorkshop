using CleanArchitectureWorkshop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Domain.Entities
{
    public class Category : AuditableEntity
    {

        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
