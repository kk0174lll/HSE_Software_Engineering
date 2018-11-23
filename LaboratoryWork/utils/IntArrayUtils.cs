using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.utils
{
    class IntArrayUtils : UniArrayUtils<int>
    {

        public override int ElementFromRandom(String index)
        {
            return Utils.random.Next(0, 100);
        }

        public override int ElementFromHand(String index)
        {
            return Utils.ReadInt($"array_{index}");
        }

    }
}
