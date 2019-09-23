using System;
using System.Globalization;

namespace lecture_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtNow = DateTime.Now;

            Console.WriteLine("The current UI culture is " + CultureInfo.CurrentCulture.ToString());

            Console.WriteLine("Hello World! The time is now: " + dtNow.ToString());

            Console.WriteLine("Hello World! The time is now: " + DateTime.Now.ToString());
            //1 tick is 1/10,000,000 of a second
            Console.WriteLine("Ticks 1: " + dtNow.Ticks.ToString("N0"));
            //with n0 we are formatting number into seperated by ,
            Console.WriteLine("Ticks 2: " + DateTime.Now.Ticks.ToString("N0"));

            CultureInfo.CurrentCulture = new CultureInfo("tr-TR", false);

            Console.WriteLine("The current UI culture is " + CultureInfo.CurrentCulture.ToString());

            Console.WriteLine("Hello World! The time is now: " + dtNow.ToString());

            Console.WriteLine("Hello World! The time is now: " + DateTime.Now.ToString());

            Console.WriteLine("Ticks 1: " + dtNow.Ticks.ToString("N0"));

            Console.WriteLine("Ticks 2: " + DateTime.Now.Ticks.ToString("N0"));

            Console.ReadLine();
        }
    }
}
