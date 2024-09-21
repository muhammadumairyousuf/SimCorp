using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount.Services
{
    public class WordProcessor
    {
        public IEnumerable<string> ProcessText(string text)
        {
            // Normalize the text by converting to lowercase and splitting into words
            return text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(word => word.ToLowerInvariant());
        }
    }
}
