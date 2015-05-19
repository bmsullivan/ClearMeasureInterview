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

        [Test]
        public void ShouldReturnStringsInCorrectOrder()
        {
            var fb = new FizzBuzzer();
            var matchers = new List<DivisableMatcher>
            {
                new DivisableMatcher(3, "Fizz"),
                new DivisableMatcher(5, "Buzz")
            };
            var results = fb.DoFizzBuzz(1,15, matchers);
            
            Assert.That(results[0], Is.EqualTo("1"));
            Assert.That(results[1], Is.EqualTo("2"));
            Assert.That(results[2], Is.EqualTo("Fizz"));
            Assert.That(results[3], Is.EqualTo("4"));
            Assert.That(results[4], Is.EqualTo("Buzz"));
            Assert.That(results[5], Is.EqualTo("Fizz"));
            Assert.That(results[6], Is.EqualTo("7"));
            Assert.That(results[7], Is.EqualTo("8"));
            Assert.That(results[8], Is.EqualTo("Fizz"));
            Assert.That(results[9], Is.EqualTo("Buzz"));
            Assert.That(results[10], Is.EqualTo("11"));
            Assert.That(results[11], Is.EqualTo("Fizz"));
            Assert.That(results[12], Is.EqualTo("13"));
            Assert.That(results[13], Is.EqualTo("14"));
            Assert.That(results[14], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ShouldConcatenateAllMatches()
        {
            var fb = new FizzBuzzer();
            var matchers = new List<DivisableMatcher>
            {
                new DivisableMatcher(1, "Fizz"),
                new DivisableMatcher(1, "Buzz"),
                new DivisableMatcher(1, "Foo"),
                new DivisableMatcher(1, "Bar")
            };
            var results = fb.DoFizzBuzz(1,10, matchers);
            Assert.That(results.All(s => s == "FizzBuzzFooBar"), Is.True);
        }
    }
}
