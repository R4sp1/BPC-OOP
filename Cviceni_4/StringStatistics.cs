using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cviceni_4
{
    public class StringStatistic
    {
        string text;
        string justText;

        public StringStatistic(string text)                                                         //Konstruktor
        {
            this.text = text;
            justText = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
        }

        public int WordCount()                                                                      //Pocet slov
        {
            var count = justText.Split(' ').Length;
            return count;
        }

        public int LineCount()                                                                      //Pocet radku
        {
            var count = text.Split('\n').Length;
            return count;
        }

        public int SentenceCount()                                                                  //Pocet vet
        {
            var sentenceString = text.Replace("\n", " ").Replace(",", "").Replace("\n", " ").Replace("(", "").Replace(")", "");
            string[] splitSentences = Regex.Split(sentenceString, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");
            var count = splitSentences.Length;
            return count;
        }

        public List<string> LongestWords()                                                          //List nejdelsich slov
        {
            string[] wordsString = justText.Split(' ');

            var orderedString = wordsString.OrderBy(x => x.Length).ToList<string>();                //Razeni od nejkratsich slov
            orderedString.Reverse();                                                                //Pro nejdelsi slova pouze string otočím

            var finalList = new List<string>();                                                     //Vytvoreni listu nejdelsich slov
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

        public List<string> ShortestWords()                                                         //List nejkratsich slov
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

        public string[] MostWords()                                                                 //Pole nejpouzivanejsich slov
        {
            string[] wordsString = justText.Split(' ');

            var nameGroup = wordsString.GroupBy(x => x);
            var maxCount = nameGroup.Max(g => g.Count());
            var finalList = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();

            return finalList;
        }

        public List<string> WordsByAlphabet()                                                       //List slov serazenych podle abecedy
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