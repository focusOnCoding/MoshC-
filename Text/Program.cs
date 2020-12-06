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

            var text = "This is going to be a really really really really really long text";
            var summary = stringUtility.SummerizeText(text, 35);
            Console.WriteLine(summary);
        }
        
    }
}
