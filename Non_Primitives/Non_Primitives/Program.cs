using System;

namespace Non_Primitives
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference Type and Value Types

            // Value Types E.G
            var a = 10;
            // copy a to b so the value 10 will be copied because ints a vaule types
            var b = a;
            b++; // 11 beacuse intigers a value types

            Console.WriteLine("a : {0}, b : {1}",a, b);

            // Reference Type 
            var              array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            // now beacuse i changed the value of array2[0] which is // Reference Type  
            // to 0 array1 to will also change to 0
            array2[0] = 0; 

            Console.WriteLine("array[0]: {0}, array2[0]: {1}", array1[0], array2[0]);

            var number = 1;
            // Value Type
            Increment(number); // still 1 not changed because im using a different copy

            var person = new Person() { Age = 20 };
            // Referance Type
            MakeOld(person); // 30 because im using the same copy as the person class
            Console.WriteLine(person.Age);
        }
        
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
        public class Person
    {
        public int Age;
    } 
}
