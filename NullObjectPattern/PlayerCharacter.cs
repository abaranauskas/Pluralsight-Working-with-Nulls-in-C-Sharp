using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class PlayerCharacter
    {
        //public PlayerCharacter(ISpecialDefence specialDefence)  //interface
        public PlayerCharacter(SpacialDefenceAbstarct specialDefence) //abstractclass
        {
            _specialDefence = specialDefence;
        }


        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if (_specialDefence!=null)
            //{
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}

            //int totslDamageTaken = damage - damageReduction;


            //--------------------------------------------------------------
            //kai sukuriame Null object ir perduodame in program tada uztenka tik sios eilutes
            //vietoj virs bruksnio visu
            int totslDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);


            Health -= totslDamageTaken;

            Console.WriteLine($"{Name}'s health has been redused by {totslDamageTaken} to {Health}.");

        }




        public string Name { get; set; }
        public int Health { get; set; } = 100;

        //private readonly ISpecialDefence _specialDefence;
        private readonly SpacialDefenceAbstarct _specialDefence;
    }
}
