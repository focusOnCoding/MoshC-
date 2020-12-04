using System;
using System.Collections.Generic;

namespace Arrays_And_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 14, 12, 6 };

            // length size
            Console.WriteLine("length of array : {0}", numbers.Length);

            // indexOf
            var index = Array.IndexOf(numbers, 14);
            Console.WriteLine("ndex of array : {0}", index);

            // Clear() set to 0 if int
            Array.Clear(numbers, 0, 2);

            // Copy
            int[] another = new int[3];
            // copy numbers array to anther array
            Array.Copy(numbers, another, 3);

            // Sort
            Array.Sort(numbers);

            // Reverse
            Array.Reverse(numbers);

            Console.WriteLine("List -------------------------------------------------------------");
            
            // in a list i can add more values in a Array i cant do that it has fixed type
            var listNumbers = new List<int>() { 1, 2, 3, 4 };
            listNumbers.Add(12); // add to list
            listNumbers.AddRange(new int[3] { 5, 6, 7}); // add an array

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            listNumbers.IndexOf(1); // Search from return first instance
            listNumbers.LastIndexOf(1); // return last instance of element
            // number of objects in a list
            var numberOfObjects = listNumbers.Count;

            // Remove object in list
            listNumbers.Remove(1);
            // remove all 1
            foreach (var number in listNumbers)
            {
                if (number == 1)
                {
                    // this may sometime return a error
                    // because i should not modify a list inside a foreach loop
                    listNumbers.Remove(number);
                }
            }

            // a better way of doing the above
            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] == 1)
                {
                    listNumbers.Remove(listNumbers[i]);
                }
            }

            foreach (var number in listNumbers)
            {
                Console.WriteLine(number);
            }

            // Remove all elements
            listNumbers.Clear();


        }
    }
}
