using ClearMeasureInterview.Lib;
using NUnit.Framework;

namespace ClearMeasureInterview.Test
{
    [TestFixture]
    public class MatcherTests
    {
        [Test]
        public void ShouldReturnTrueForDivisableArgument()
        {
            var m = new DivisableMatcher(3, "Fizz");
            Assert.That(m.Matches(9), Is.True);
        }

        [Test]
        public void ShouldReturnFalseForNonDivisibleArgument()
        {
            var m = new DivisableMatcher(3, "Fizz");
            Assert.That(m.Matches(8), Is.False);
        }
    }
}