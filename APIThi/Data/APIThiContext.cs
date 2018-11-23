using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APIThi.Models
{
    public class APIThiContext : DbContext
    {
        public APIThiContext (DbContextOptions<APIThiContext> options)
            : base(options)
        {
        }

        public DbSet<APIThi.Models.Employee> Employee { get; set; }
    }
}
