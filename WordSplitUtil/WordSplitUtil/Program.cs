using System;
using System.Linq;

namespace WordSplitUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            printArrayWords(new string[] { "Hello", "Ben", "How Are You", "Goce Jankovski" }, '*');

            printArrayWords(new string[] { "Tampa", "Charlotte", "Chicago", "Milwaukee" }, '*');

        }

        static void printArrayWords(string[] wordsArray, char specialCharacter)
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
