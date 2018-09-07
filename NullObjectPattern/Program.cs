using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new PlayerCharacter(new DiamonSkinDefence())
            {
                Name = "Sarah"
            };

            //var john = new PlayerCharacter(new IronBonesDefence())
            var john = new PlayerCharacter(SpacialDefenceAbstarct.Null)
            {
                Name = "John"
            };

            //var garett = new PlayerCharacter(new NullDefence())
            var garett = new PlayerCharacter(SpacialDefenceAbstarct.Null)
            {
                Name = "Garett"
            };

            sarah.Hit(10);
            john.Hit(10);
            garett.Hit(10);

        }
    }
}
