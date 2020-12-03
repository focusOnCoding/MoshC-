using System;

namespace Non_Primitives
{
    // a Enum is internally an intiger
    // Enum is a new  type it must be declard in the namespace scope
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            // cast enum to int then print it out to the console
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
        }
    }
}
