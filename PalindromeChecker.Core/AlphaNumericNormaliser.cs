using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeChecker.Core
{
    public class AlphaNumericNormaliser : IStringNormaliser
    {
        public string Normalise(string input)
        {
            return new string(input.ToLower().Where(char.IsLetter).ToArray());
        }
    }
}