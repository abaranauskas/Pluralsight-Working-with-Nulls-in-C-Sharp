using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class DiamonSkinDefence : SpacialDefenceAbstarct //ISpecialDefence
    {
        //kai pakeiciam is interface i abstract reikia override
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
