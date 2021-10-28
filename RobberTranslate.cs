using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robber_translator
{
    static class RobberTranslate
    {
        private static readonly string consonants = "bcdfghjklmnpqrstvwxz";
        internal static string ToRobber(string phrase)
        {
            string output = "";
            phrase = phrase.ToLower();

            for (int i = 0; i < phrase.Length; i++)
            {
                char letter = phrase[i];
                if (consonants.Contains(letter))
                {
                    output += letter + "o";
                }
                output += letter;
            }

            return output;
        }

        internal static string FromRobber(string phrase)
        {
            string output = "";
            phrase = phrase.ToLower();

            for (int i = 0; i < phrase.Length; i++)
            {
                if ((i <= phrase.Length - 2)
                    && (consonants.Contains(phrase[i]))
                    && (phrase[i + 1] == 'o')
                    && (phrase[i + 2] == phrase[i]))
                {
                    i += 2;
                }
                output += phrase[i];
            }

            return output;
        }
    }
}
