using System;

namespace Lab3_5DotNetContainsSpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Updated and works but needs refactoring!
            // - More words in BlackList
            // - Resolve Uppercase/Lowercase issue with words.
            // - Use external db or flatfile that is easy to update
            //      without having to update the code.
            // Added by th 06232020

            Console.WriteLine("Hello World Lab3_5DotNetContainsSpamChecker!");

            string blackListWord = "Fudge";
            bool isSpam = false;

            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }

        }
    }
}
