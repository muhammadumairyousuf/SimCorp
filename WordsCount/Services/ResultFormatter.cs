using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount.Services
{
    public class ResultFormatter
    {
        public void PrintResults(Dictionary<string, int> wordCount)
        {
            var sortedResults = wordCount.OrderByDescending(k => k.Value).ThenBy(k => k.Key);

            foreach (var word in sortedResults)
            {
                Console.WriteLine($"{word.Value}: {word.Key}");
            }
        }
    }
}
