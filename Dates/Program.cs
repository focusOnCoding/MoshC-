using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now; // get current time
            var today = DateTime.Today; // get todays date

            Console.WriteLine("Houre: {0}",now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);

            // Date is imuteble but i can change it using the Add() method
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // format date to string
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString()); // display all information about the day
            // format the date
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            Console.WriteLine("Time Span -=-------------------------------------------------------------");
            
            // HH:MM:SS
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpane1 = new TimeSpan(1, 0, 0);
            // write time spane in a more readeble way
            var timeSpane2 = TimeSpan.FromHours(1);

            // i can create a timespane by - two dates 
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: {0}",duration);

            // Read properties of time spane
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("otal Minutes: " + timeSpan.TotalMinutes);

            // modify time spane with (add and subtract) this returns a new timespan
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // convert to string
            Console.WriteLine("ToSting: " + timeSpan.ToString());
            // convert String to TimeSpan
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
