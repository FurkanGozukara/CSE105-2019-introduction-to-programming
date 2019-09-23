using System;
using System.Globalization;

namespace lecture_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //here it takes your computers own language

            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            //here it takes en us language

            DateTime dtNow = DateTime.Now;

            printOurScreen(dtNow);

            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            //here it takes tr turkish language

            printOurScreen(dtNow);

            Console.ReadLine();
        }

        //private means its accesbility only inside  class Program
        //static means it does not need to be initialized into an object to call
        //void means it returns nothing
        //() is its constructor
        private static void printOurScreen(DateTime dtNow)
        {
            Console.WriteLine("The current UI culture is " + CultureInfo.CurrentCulture.ToString());

            Console.WriteLine("Hello World! The time is now: " + dtNow.ToString());

            Console.WriteLine("Hello World! The time is now: " + DateTime.Now.ToString());
            //1 tick is 1/10,000,000 of a second
            Console.WriteLine("Ticks 1: " + dtNow.Ticks.ToString("N0"));
            //with n0 we are formatting number into seperated by ,
            Console.WriteLine("Ticks 2: " + DateTime.Now.Ticks.ToString("N0"));
        }
    }
}
