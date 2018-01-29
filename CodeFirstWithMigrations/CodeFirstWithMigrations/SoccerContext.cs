using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithMigrations
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("name=SoccerContext")
        {

        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

    }
}
