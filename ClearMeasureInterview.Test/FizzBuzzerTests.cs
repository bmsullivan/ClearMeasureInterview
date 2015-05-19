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
            var results = fb.DoFizzBuzz(1,100);

            Assert.That(results.Count(), Is.EqualTo(100));
        }

        [Test]
        public void ShouldReturnCorrectStrings()
        {
            var fb = new FizzBuzzer();
            var results = fb.DoFizzBuzz(1,100);
        
            Assert.That(results.Count(s => s == "Fizz"), Is.EqualTo(27));
            Assert.That(results.Count(s => s == "Buzz"), Is.EqualTo(14));
            Assert.That(results.Count(s => s == "FizzBuzz"), Is.EqualTo(6));
        }
    }
}
