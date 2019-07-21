using System;
using System.Linq;

namespace WordSplitUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            printArrayWords(new string[] { "Hello", "Ben", "How Are You", "Goce Jankovski" }, '*');

            printArrayWords(new string[] { "London", "Charlotte", "New York", "Chicago" }, '*');

            printArrayWords(new string[] {}, '*');

            printArrayWords(null, '*');
        }

        static void printArrayWords(string[] wordsArray, char specialCharacter)
        {
            if (wordsArray != null && wordsArray.Count() > 0)
            {
                WordUtil wUtil = new WordUtil();
                int wordLongLen = wUtil.getLongestStringArray(wordsArray);

                wUtil.printCharacters(specialCharacter, wordLongLen + 4);

                wordsArray.ToList().ForEach(w =>
                    Console.WriteLine(specialCharacter + " "
                                        + w.ToString().PadRight(wordLongLen)
                                        + " "
                                        + specialCharacter));

                wUtil.printCharacters(specialCharacter, wordLongLen + 4);
            }
            else
                Console.WriteLine("Array is empty");

        }
    }

    public class WordUtil
    {
        public void printCharacters(char specialCharacter, int howMany)
        {
            Console.Write(string.Concat(Enumerable.Repeat(specialCharacter, howMany)));
            Console.WriteLine(string.Empty);
        }

        public int getLongestStringArray(string[] wordsArray)
        {
            return wordsArray != null ? wordsArray.Max(w => w.Length) : 0;
        }
    }
}
