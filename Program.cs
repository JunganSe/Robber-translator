using System;

namespace Robber_translator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a phrase to translate or q to quit.");
                string phrase = Console.ReadLine();
                if (phrase == "q") { break; }

                string robberPhrase = RobberTranslate.ToRobber(phrase);
                Console.WriteLine("\nTranslated to robber:\n" + robberPhrase);

                string normalPhrase = RobberTranslate.FromRobber(robberPhrase);
                Console.WriteLine("\nTranslated back from robber:\n" + normalPhrase);

                Console.WriteLine("\n\n");
            }
        }
    }
}
