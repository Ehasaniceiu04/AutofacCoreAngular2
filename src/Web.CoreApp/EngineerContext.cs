using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CoreApp.Model
{
    public class EngineerContext:DbContext
    {
        public EngineerContext(DbContextOptions<EngineerContext> options)
      : base(options)
        {
        }

        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Experience> Experiences { get; set; }
    }
}
