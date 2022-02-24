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
    }
}