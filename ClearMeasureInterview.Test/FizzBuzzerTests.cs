using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasureInterview.Lib;
using NUnit.Framework;

namespace ClearMeasureInterview.Test
{
    [TestFixture]
    class FizzBuzzerTests
    {
        [Test]
        public void ShouldReturnCorrectNumberOfResults()
        {
            var fb = new FizzBuzzer();
            var matchers = new List<DivisableMatcher>
            {
                new DivisableMatcher(3, "Fizz"),
                new DivisableMatcher(5, "Buzz")
            };
            var results = fb.DoFizzBuzz(1,100, matchers);

            Assert.That(results.Count(), Is.EqualTo(100));
        }

        [Test]
        public void ShouldReturnCorrectStrings()
        {
            var fb = new FizzBuzzer();
            var matchers = new List<DivisableMatcher>
            {
                new DivisableMatcher(3, "Fizz"),
                new DivisableMatcher(5, "Buzz"),
                new DivisableMatcher(37, "Foo")
            };
            var results = fb.DoFizzBuzz(1,100, matchers);
        
            Assert.That(results.Count(s => s == "Fizz"), Is.EqualTo(27));
            Assert.That(results.Count(s => s == "Buzz"), Is.EqualTo(14));
            Assert.That(results.Count(s => s == "FizzBuzz"), Is.EqualTo(6));
            Assert.That(results.Count(s => s == "Foo"), Is.EqualTo(2));
            Assert.That(results[82], Is.EqualTo("83"));
        }
    }
}
