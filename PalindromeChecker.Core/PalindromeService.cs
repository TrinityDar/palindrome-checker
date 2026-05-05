using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeChecker.Core
{
    public class PalindromeService
    {
        private readonly IStringNormaliser _normaliser;
        public PalindromeService(IStringNormaliser normaliser)
        {
            _normaliser = normaliser;
        }
        public bool IsPalindrome(string input)
        {
            var cleaned = _normaliser.Normalise(input);
            return cleaned == new string(cleaned.Reverse().ToArray());
        }
    }
}