using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cviceni_4
{
    public class StringStatistic
    {
        string text;
        string justText;

        public StringStatistic(string text)
        {
            this.text = text;
            justText = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
        }

        public int WordCount()
        {
            var count = justText.Split(' ').Length;
            return count;
        }

        public int LineCount()
        {
            var count = text.Split('\n').Length;
            return count;
        }

        public int SentenceCount()
        {
            var sentenceString = text.Replace("\n", " ").Replace(",", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
            string[] splitSentences = Regex.Split(sentenceString, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");
            var count = splitSentences.Length;
            return count;
        }

        public List<string> LongestWords()
        {
            string[] wordsString = justText.Split(' ');

            var orderedString = wordsString.OrderBy(x => x.Length).ToList<string>();
            orderedString.Reverse();

            var finalList = new List<string>();
            var len = 0;
            foreach (var word in orderedString)
            {
                if (word.Length >= len)
                {
                    len = word.Length;
                    finalList.Add(word);
                }
            }

            return finalList;
        }

        public List<string> ShortestWords()
        {

            string[] wordsString = justText.Split(' ');

            var orderedString = wordsString.OrderBy(x => x.Length).ToList<string>();

            var finalList = new List<string>();
            var len = 1000;
            foreach (var word in orderedString)
            {
                if (word.Length <= len)
                {
                    len = word.Length;
                    finalList.Add(word);
                }
            }
            return finalList;
        }

        public string[] MostWords()
        {
            string[] wordsString = justText.Split(' ');

            var nameGroup = wordsString.GroupBy(x => x);
            var maxCount = nameGroup.Max(g => g.Count());
            var finalList = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();

            return finalList;
        }

        public List<string> WordsByAlphabet()
        {
            string[] wordsString = justText.Split(' ');

            var list = new List<string>();
            foreach (var word in wordsString)
            {
                list.Add(word);
            }
            list.Sort();
            return list;
        }
    }
}