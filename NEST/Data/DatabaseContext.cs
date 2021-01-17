using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NEST.Models;
namespace NEST.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){ }
        public DbSet<IsolationPointTools> IsolationPointTools { get; set; }
        public DbSet<IsolationPointList> IsolationPointList{ get; set; }
    }
}
