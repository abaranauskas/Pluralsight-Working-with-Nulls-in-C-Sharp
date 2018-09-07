using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class IronBonesDefence : SpacialDefenceAbstarct //ISpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
