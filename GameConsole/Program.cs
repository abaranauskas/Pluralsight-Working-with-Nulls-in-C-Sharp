using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = null;
            //player.Name = "Aidas";
            //player.DaysSinceLastLogIn = 54;

            //PlayerDisplayer.Write(player);


            //int days = player.DaysSinceLastLogIn.Value;
            //jei nenustatyta ir bandoma pasiekti per Value prop bus runtime error

            int days2 = player?.DaysSinceLastLogIn ?? -99;
            // "Null-Conditional" "?." - operator pirmiausia tikrina ar
            //player yra null ir jei null iskart pagal ?? paims -99
            //tada jei DaysSinceLastLogIn yra null irgi paims -99
            //ir galiausiai jei DaysSinceLastLogIn ne null paims 
            Console.WriteLine(days2);

            int days;

            if (player!=null)
            {
                days = player.DaysSinceLastLogIn ?? -77;
                //coalesing ?? operator
            } else
            {
                days = -888;
            }

            Console.WriteLine(days);
            Console.WriteLine();

            PlayerCharacter[] players = new PlayerCharacter[]
            {
                new PlayerCharacter() {Name="Aidas B." }, //Name = "Aidas B"
                new PlayerCharacter(),      //Name = null
                null                        //PlayerCharacter = null
            };

            //PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
            //tas pats "Null conditional" operator "?." tik su array rasosi "?[" 
            //tikrina ar player ne null tada ar name ne null ir priskiria Name
            //jei bent vienas is ju null priskiria null
            //jokio erro ner net jei players yra null
            Console.WriteLine(p1);


        }
    }
}
