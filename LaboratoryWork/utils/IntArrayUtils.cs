using System;

namespace LaboratoryWork
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
