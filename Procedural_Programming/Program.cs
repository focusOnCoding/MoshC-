using System;

namespace Procedural_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // putting code where it belong (Grouping code) (family) (familier)
            // code for console and logic implementation should be separated

            Console.WriteLine("What is your name: ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }
        // logic group here leave the console above      
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                array[name.Length - i] = name[i - 1];
            }

            // cut this out
            //var reversed = new string(array); 

            // return the above strat away
            //return reversed;
            return new string(array);
        }
    }
}
