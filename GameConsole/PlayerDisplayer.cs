using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (!string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine(player.Name);
            } else
            {
                Console.WriteLine("Proper name have not been given");
            }




            //int days = player.DaysSinceLastLogIn.HasValue ? player.DaysSinceLastLogIn.Value : -6;

            int days = player.DaysSinceLastLogIn ?? -6;
            // coalesing operator (jei kairej null) ?? (tada defaul value is cia paims) 
            //jei ne null kairej tada ta reiksme ir paims


            //int days = player.DaysSinceLastLogIn.GetValueOrDefault(-1);
            //GetValueOrDefault(); metodas paims value jei nustatyta
            //jei ne ir i skliaustus nieko neyrasyta bus nulis jei 
            //skliaustuose yrasyta tai ta ir bus vertedefault

            Console.WriteLine($"days since last login: {days}");



            //if (player.DaysSinceLastLogIn!=null)
            //if (player.DaysSinceLastLogIn.HasValue) //Nullable<T> HasVAlue prop
            //{
            //    Console.WriteLine(player.DaysSinceLastLogIn.Value);
                //su value skirtumas tik tas kat returnina int o ne int?
            //}
            //else
            //{                
            //    Console.WriteLine("No Value for DaysSinceLastLogin");                                          
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Date of Birth Speciafied");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }


            if (player.IsNoob==null)
            {
                Console.WriteLine("Player's newbie status is unknown");
            }
            else if (player.IsNoob==true )
            {
                Console.WriteLine("Player's newbie");
            }
            else
            {
                Console.WriteLine("Player is expert");
            }


        }
    }
}
