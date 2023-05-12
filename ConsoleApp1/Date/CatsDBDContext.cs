using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Date
{
    internal class CatsDBDContext:DbContext
    {
        public CatsDBDContext() : base("CatsDBDContext")
        { }
        public DbSet<Cat>Cats { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
