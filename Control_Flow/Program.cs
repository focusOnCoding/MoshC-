using System;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("let it flow..");

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("Its Morning");
            }

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            // write the abouve as a condition
            float price1 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price1);
        }
    }
}
