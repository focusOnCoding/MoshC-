using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteNumber = 2;
            int count = 10;
            float totalPrice = 20.95f;
            decimal Dnumber = 1200.0m;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;
            Console.WriteLine("{0} {1} {2} {3} {4}", count, totalPrice, character, firstName, isWorking);
            Console.WriteLine("Hello World! it has started");
            
            // let the compiler figur out whats the type is
            var myName = "Siyabonga";

            const float Pi = 3.14f; // this value cant be changed

            // CTRL + CLICK    see more about type

            // check for range
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);

            
        }
    }
}
