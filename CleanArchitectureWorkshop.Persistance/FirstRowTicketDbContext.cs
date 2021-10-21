using CleanArchitectureWorkshop.Domain.Entities;
using CleanArchitectureWorkshop.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Persistance
{
    public class FirstRowTicketDbContext : DbContext
    {
        public FirstRowTicketDbContext(DbContextOptions<FirstRowTicketDbContext> options) : base (options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                            break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                            break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
