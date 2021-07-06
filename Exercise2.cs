using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "we", "They", "Hi", "Car", "She", "True" };
            String lastWord = GetTheLastWord(words);

            if (IsLastWordNull(lastWord))
                Console.WriteLine(lastWord);
            else
                Console.WriteLine("The last word is {0}", lastWord);
        }

        public static string GetTheLastWord(IEnumerable<string> words)
        {
            string LastWord = words.Where(word => word.Contains('e'))
                                    .OrderBy(word => word)
                                    .LastOrDefault();
            return LastWord;

        }
        public static bool IsLastWordNull(String LastWord)
        {
            return LastWord == null;
        }


    }

}