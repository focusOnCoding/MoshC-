using System;
// add the PersonClass Namespace
using Classes_Demo.Math;

namespace Classes_Demo
{
    public class Person0
    {
        public string FirstNane;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is :" + FirstNane + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Siya = new Person0();
            // assign fields to the new object
            Siya.FirstNane = "Siyabonga";
            Siya.LastName = "Dlamini";
            Siya.Introduce();

            // use person class in the Calculater folder
            Calculater calculater = new Calculater();
            var result = calculater.Add(1, 2);
            Console.WriteLine(result); // output the variables value 
        }
    }
}
