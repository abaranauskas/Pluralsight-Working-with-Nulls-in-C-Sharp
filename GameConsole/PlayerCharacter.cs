using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
       
        public PlayerCharacter(ISpecialDefence specialDefence)
        {            
           
            //DaysSinceLastLogIn = null;
           // DateOfBirth = null;

            //magic numbers bloga praktika
            //DaysSinceLastLogIn = -1;  //magic number
            // DateOfBirth = DateTime.MinValue;  //magic number
        }
        

        public string Name { get; set; } //kadangi class tipas gali but null

        //negali buti null nes struct        
        public Nullable<int> DaysSinceLastLogIn { get; set; }
        //public Nullable<DateTime> DateOfBirth { get; set; }

        public DateTime? DateOfBirth { get; set; }
        // "?"  po tipo shortcut Nullable<DateTime>


        public bool? IsNoob { get; set; } 
        //defaut reiksme nullable<T> yra null

    }
}
