using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10)); // generat numbers 1 to 10

            // see what the string 'a' is as ASCII in bytes
            Console.WriteLine((int)'a');

            // Generat random string into password
            var randomString = new Random();
            for (int i = 0; i < 10; i++)
                // cast to (charater)
                Console.WriteLine((char)randomString.Next(97, 122)); // A => Z 97 => 122

            // a more axpresive way to writethe above code
            var moreReadeble = new Random();
            for (int i = 0; i < 10; i++)
                // use Console.write to make the out write in the same line
                Console.WriteLine((char)('a' + moreReadeble.Next(0, 26))); // because there a 26 charaters in the english language

            // create the above but store it in a array buffer
            var randomBuffer = new Random();
            // make 10 a constso ill change it in one place in the futur if i need to change it
            const int passwordlength = 10;      
            var buffer = new char[passwordlength];
            
            for (int i = 0; i < passwordlength; i++)
                buffer[i] = ((char)randomBuffer.Next(97, 122));
            // create a string biested on ths array
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
