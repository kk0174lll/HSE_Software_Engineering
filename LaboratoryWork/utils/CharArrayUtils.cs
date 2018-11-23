using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.utils
{
    class CharArrayUtils : UniArrayUtils<char>
    {
        char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public override char ElementFromHand(string index)
        {
            return ElementFromHand(index, char.TryParse);
        }

        public override char ElementFromRandom(string index)
        {
            return alphabet[Utils.random.Next(0, alphabet.Length)];
        }
    }
}
