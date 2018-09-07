using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public abstract class SpacialDefenceAbstarct
    {
        public abstract int CalculateDamageReduction(int totalDamage);


        public static SpacialDefenceAbstarct Null { get;  } = new NullDefence();



        private class NullDefence : SpacialDefenceAbstarct
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0;
            }
        }
    }
}
