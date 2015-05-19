using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearMeasureInterview.Lib
{
    public class FizzBuzzer
    {
        public List<string> DoFizzBuzz(int start, int end, List<DivisableMatcher> matchers)
        {
            var results = new List<string>();
            for (int i = start; i <= end; i++)
            {
                var line = new StringBuilder();
                
                matchers.Where(m => m.Matches(i)).ToList().ForEach(m => line.Append(m.Message));

                if (line.ToString() == String.Empty)
                {
                    line.Append(i);
                }

                results.Add(line.ToString());
            }

            return results;
        }
    }
}