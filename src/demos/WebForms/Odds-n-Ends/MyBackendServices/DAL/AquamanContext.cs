using MyBackendServices.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBackendServices.DAL
{
    internal class AquamanContext : DbContext
    {
        public AquamanContext() : base("name=amdb")
        {
            Database.SetInitializer<AquamanContext>(null);
        }

        public DbSet<Fish> SlimeyThings { get; set; }
    }
}
