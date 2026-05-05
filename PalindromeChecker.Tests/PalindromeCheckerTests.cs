using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PalindromeChecker.Core;

namespace PalindromeChecker.Tests
{
    public class PalindromeCheckerTests
    {
        private readonly PalindromeService _checker;

        public PalindromeCheckerTests()
        {
            _checker = new PalindromeService(new AlphaNumericNormaliser());
        }

        [Fact]
        public void IsPalindrome_ShouldReturnTrue_ForSimplePalindrome()
        {
            Assert.True(_checker.IsPalindrome("abcba"));
        }

        [Fact]
        public void IsPalindrome_ShouldReturnFalse_ForNonPalindrome()
        {
            Assert.False(_checker.IsPalindrome("abcde"));
        }

        [Fact]
        public void IsPalindrome_ShouldReturnTrue_ForPalindromeWithSpaces()
        {
            Assert.True(_checker.IsPalindrome("Mr owl ate my metal worm"));
        }

        [Fact]
        public void IsPalindrome_ShouldReturnTrue_ForMixedCase()
        {
            Assert.True(_checker.IsPalindrome("Never Odd Or Even"));
        }

        [Fact]
        public void IsPalindrome_ShouldReturnFalse_ForMixedCaseNonPalindrome()
        {
            Assert.False(_checker.IsPalindrome("Never Even Or Odd"));
        }      
    }
}