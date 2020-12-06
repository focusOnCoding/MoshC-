using System;
using System.Collections.Generic;
using System.Text;

namespace Text
{
    // make class public so im can see it in ather files
    public class stringUtility
    {
        // this also needs to be public
        public static string SummerizeText(string text, int maxlength = 20)
        {

            if (text.Length < maxlength)
                return text;

            // poor way
            //text.Substring(0, maxlength);

            // better way
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>(); // store the new returned words
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += words.Length + 1; // increment word and add to totalCharacters
                if (totalCharacters > maxlength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";

        }
    }
}
