using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //Test 1

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Test 2

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Test 3

        [TestMethod]
        public void CharsInsideBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        //Test 4

        [TestMethod] 
        public void BracketsInsideCharsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        //Test 5

        [TestMethod]
        public void BracketsOutsideCharsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        //Test 6

        [TestMethod]
        public void StringWithoutBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        //Test 7

        [TestMethod]
        public void BracketsWithExcessWhiteSpaceReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[            ]"));
        }

        //Test 8

        [TestMethod] 
        public void SingleBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //Test 9

        [TestMethod]
        public void UnbalancedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        //Test 10

        [TestMethod]
        public void SingleBracketWithCharsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        //Test 11

        [TestMethod]
        public void UnbalancedBracketsInsideCharsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        //Test 12

        [TestMethod] 
        public void ExcessWhiteSpaceBetweenUnbalancedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]           ["));
        }

        //Test 13

        [TestMethod]
        public void UnbalancedBracketsWithBalancedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][LaunchCode]["));
        }        
    }
}
