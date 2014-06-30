using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WordFinder.Core
{
    public static class WordFinder
    {
        public static void Search(string loadedFile, string referenceWord)
        {
            var text = File.ReadAllText(loadedFile);

            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var matchQuery = from word in source
                             where word.ToLowerInvariant() == referenceWord.ToLowerInvariant()
                             select word;

            int wordCount = matchQuery.Count();
        }
    }
}
