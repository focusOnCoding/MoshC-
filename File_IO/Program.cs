using System;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\LENOVO-PC\Desktop\the random";

            // working with File info static methods
            // move | copy file
            File.Copy(@"C:\Users\LENOVO-PC\Desktop\the random\map.txt", @"C:\Users\LENOVO-PC\Desktop\the random\copyTo\map.txt", true);

            // delete file
            File.Delete(@"C:\Users\LENOVO-PC\Desktop\the random\copyTo\map.txt");

            // check for files
            //if (File.Exists(path))
            //{
            //    //
            //}

            // Read text file
            var path2 = @"C:\Users\LENOVO-PC\Desktop\the random\map.txt";
            var content = File.ReadAllText(path2);

            // file info instance methods
            var fileInfo = new FileInfo(path);
        //    fileInfo.CopyTo(@"C:\Users\LENOVO - PC\Desktop\the random\copyTo");
        //    fileInfo.Delete();
            if (fileInfo.Exists)
            {
                // do something
            }

            // Diectory and Directory Info
            Directory.CreateDirectory(@"C: \Users\LENOVO - PC\Desktop\the random\copyTo\masiyaWami");

            var fileDs = Directory.GetFiles(@"C: \Users\LENOVO - PC\Desktop\the random", "*.txt", SearchOption.AllDirectories);
            foreach (var files in fileDs)
            {
                Console.WriteLine(files);
            } 
        }
    }
}
