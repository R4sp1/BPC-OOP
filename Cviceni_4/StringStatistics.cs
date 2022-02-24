using System;

namespace Cviceni_4{
    public class StringStatistic{
        string text;

        public StringStatistic(string text){
            this.text = text;
        }

        public int WordCount(){
            var count = text.Split(' ').Length;
            return count;
        }

        public int LineCount(){
            var count = text.Split('\n').Length;
            return count;
        }

        public int SentenceCount(){
            var countPeriods = text.Split('.').Length;
            var countExclamationMarks = text.Split('!').Length;
            var countQuestionMarks = text.Split('?').Length;
            return countPeriods + countExclamationMarks + countQuestionMarks;
        }

        public List<string> LongestWord(){
            var justText = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "");
            string[] wordsString = justText.Split(' ');

            var orderedString = wordsString.OrderBy(x => x.Length).ToList<string>();
            orderedString.Reverse();

            var finalList = new List<string>();
            var len = 0;
            foreach (var word in orderedString) {
                if (word.Length >= len) {
                    len = word.Length;
                    finalList.Add(word);
                }
            }

            return finalList;
        }

        public List<string> ShortestWord(){
            var justText = text.Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "");
            string[] wordsString = justText.Split(' ');

            var orderedString = wordsString.OrderBy(x => x.Length).ToList<string>();

            var finalList = new List<string>();
            var len = 1000;
            foreach (var word in orderedString) {
                if (word.Length <= len) {
                    len = word.Length;
                    finalList.Add(word);
                }
            }

            return finalList;
        }
    }
}