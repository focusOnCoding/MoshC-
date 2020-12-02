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
            Console.WriteLine("My Name is : " + FirstNane + " " + LastName);
        }
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

            Console.WriteLine("Arrays Demo ----------------------------------------------------------------------");

            // Arrays Demo
            var number = new int[4];
            number[0] = 1;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]); // emty indexies will be [0]
            Console.WriteLine(number[2]); // course return type is init | numbers
            Console.WriteLine(number[3]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // emty elements will be [false]
            Console.WriteLine(flags[2]); // course return type is bool

            var names = new string[3] { "Siyabonga", "Nosipho", "Nondalo" };

            Console.WriteLine("String Demo -----------------------------------------------------------------------");

            var firstName_ = "MR Dlamini";
            var lastName_ = "Dlamini";

            var fullName_ = firstName_ + " " + lastName_;
            var myfullName_ = string.Format("My name is : {0} {1}", firstName_, lastName_);

            var names_ = new string[3] { "Sipho", "Senzo", "Somandla" };
            // combine the strings using a , | statc methos on the string class JOIN
            var formattedNames = string.Join(",", names_);
            Console.WriteLine(formattedNames);

            var textOne = "Hi Siya\nlook into the following paths\nC:\\folder1\\folder2\nC:\\folder3\\folder4";
            Console.WriteLine(textOne);
            // make the above look better using vabatim string
            var textTo = @"Hi Siya\nlook into the following paths
                            C:\folder1\folder2
                            C:\folder3\folder4";
            Console.WriteLine(textTo);
        }
    }
    class Program
    {
    }
}
