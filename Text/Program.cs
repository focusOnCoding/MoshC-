using System;
using System.Collections.Generic;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Siyabonga Dlamini";
            Console.WriteLine("Trim: {0}", fullName.Trim()); // trim white space
            Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());
            
            // separate Name and Surname 
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("lastName: " + lastName);

            // better way of doing the above
            var name = fullName.Split(' '); // returns a array
            Console.WriteLine("FirstName: " + name[0]);
            Console.WriteLine("lastName: " + name[1]);

            // Replace
            fullName.Replace("Siyabonga", "Siya");
            fullName.Replace("S", "s");  // // replace S ==> s
            fullName.Replace("a", "A");  // replace a ==> A

            Console.WriteLine(fullName.Replace("Siyabonga", "Siya"));

            // working with mpty strings
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            // Convert numbers to strings
            var str = "27";
            var age = Convert.ToByte(str);

            // convert to Currency
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

            Console.WriteLine("Summarizing Text-------------------------------------------------------");

            var sentence = "This is going to be a really really really really long text";
            const int maxlength = 20;
            if (sentence.Length < maxlength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                // poor way
                //sentence.Substring(0, maxlength);

                // better way
                var words = sentence.Split(" ");
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    totalCharacters += words.Length + 1;
                    if (totalCharacters > maxlength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
                // 39
            }
        }
    }
}
