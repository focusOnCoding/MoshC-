using System;
using System.Text;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is faster than normal string munipulation because it does not return a new string every time i do something new to the string
            // with this i can create an anipulat exsisting string 
            var builder = new StringBuilder(); // not used for search
            builder.Append('-', 10); 
            builder.AppendLine();
            builder.Append('_');
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            // replace
            builder.Replace('-', 'S');
            builder.Remove(0, 5);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            var firstChar = builder[0];
            Console.WriteLine("first Char: {0}",firstChar);
        }
    }
}
