using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop

            for (int i = 0; i <= 10; i++)
            {
                // even numbers up to 10
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            for (int i = 0; i >= 1; i--)
            {
                // even numbers dicending order
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // ForEach Loop clearner then a for loop used with ENUMERABLES like string
            var name = "John Smith";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // same as above using foreah
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // iterating over an array
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // While loop best used when i dont know ahard ot time how maney times i may need to itera around something
            var ii = 0;
            while (ii <= 10)
            {
                // count from two to 10
                if (ii % 2 == 0)
                {
                    Console.WriteLine(ii);
                }
                ii++;
            }

            // get user input
            while (true)
            {
                Console.WriteLine("Type your username");
                var input = Console.ReadLine();

                // check if form is filled exit if the user fiss nothing
                if (String.IsNullOrWhiteSpace(input)) break;

                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}
