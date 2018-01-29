using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerContext context=new SoccerContext();
            context.Players.Add(new Player {Name = "Iniesta", Age = 33, Position = "M"});
        }
    }
}
