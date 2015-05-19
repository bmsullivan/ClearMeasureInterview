using System.Collections.Generic;
using System.Text;

namespace ClearMeasureInterview.Lib
{
    public class FizzBuzzer
    {
        public List<string> DoFizzBuzz(int start, int end)
        {
            var results = new List<string>();
            for (int i = start; i <= end; i++)
            {
                var line = new StringBuilder();
                if (i%3 == 0 || i%5 == 0)
                {
                    if (i%3 == 0)
                    {
                        line.Append("Fizz");
                    }
                    if (i%5 == 0)
                    {
                        line.Append("Buzz");
                    }
                }
                else
                {
                    line.Append(i);
                }

                results.Add(line.ToString());
            }

            return results;
        }
    }
}