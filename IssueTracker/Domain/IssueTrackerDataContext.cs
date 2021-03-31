using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Domain
{
    public class IssueTrackerDataContext : DbContext
    {

        public IssueTrackerDataContext(DbContextOptions<IssueTrackerDataContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
