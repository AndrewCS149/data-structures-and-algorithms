using System;
using System.Collections;

namespace RepeatedWords
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string phrase1 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string phrase2 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            string phrase3 = "it of it of";
            Console.WriteLine(RepeatedWord(phrase1));
            Console.WriteLine(RepeatedWord(phrase2));
            Console.WriteLine(RepeatedWord(phrase3));
        }

        public static string RepeatedWord(string phrase)
        {
            phrase = phrase.Replace(",", "");
            string[] phraseArr = phrase.Split(" ");

            if (phraseArr.Length <= 1)
            {
                throw new Exception("There aren't enough words to compare");
            }

            int tempIdx = 0;
            int idx = 0;

            for (int i = 0; i < phraseArr.Length - 1; i++)
            {
                for (int j = i + 1; j < phraseArr.Length; j++)
                {
                    if (phraseArr[i].ToLower() == phraseArr[j].ToLower())
                    {
                        tempIdx = j;
                        break;
                    }
                }
                if (idx == 0)
                    idx = tempIdx;
                else if (tempIdx < idx)
                    idx = tempIdx;
            }
            return phraseArr[idx];
        }
    }
}