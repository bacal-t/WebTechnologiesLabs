using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpentyStore2.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public DbSet<Door> Doors { get; set; }

        public DbSet<Land> Lands { get; set; }

        public DbSet<Armchair> Armchairs { get; set; }

        public DbSet<Table> Tables { get; set; }

    }

}