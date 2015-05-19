using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasureInterview.Lib;

namespace ClearMeasureInterview.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzzer();
            var matchers = new List<DivisableMatcher>
            {
                new DivisableMatcher(3, "Fizz"),
                new DivisableMatcher(5, "Buzz")
            };
            var results = fb.DoFizzBuzz(1, 100, matchers);
            System.Console.Write(string.Join("\n", results));
        }
    }
}
