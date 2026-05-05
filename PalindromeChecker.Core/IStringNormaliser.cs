using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeChecker.Core
{
    public interface IStringNormaliser
    {
        string Normalise(string input);
    }
}