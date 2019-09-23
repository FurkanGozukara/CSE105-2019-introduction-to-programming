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

            printMoney(122.32);
            printNumbers();

            //here it takes en us language because we have set it to

            DateTime dtNow = DateTime.Now;

            //function call
            printOurScreen(dtNow);

            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            //here it takes tr turkish language because we have set it to

            double dblMoney = 122.32;

            printMoney(dblMoney);
            printNumbers();

            printOurScreen(dtNow);

            printArrayNumbers();

            //this below line clears the console
            Console.Clear();

            printNumbersAsForLoop();

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

        static void printMoney(double dblMoney)
        {
            Console.WriteLine("money " + dblMoney.ToString("C"));
        }

        static void printNumbers()
        {
            //more information
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            double dblNum = 3211524.34543;
            Console.WriteLine("N0 = " + dblNum.ToString("N0"));
            Console.WriteLine("N1 = " + dblNum.ToString("N1"));
            Console.WriteLine("N2 = " + dblNum.ToString("N2"));
            Console.WriteLine("E = " + dblNum.ToString("E"));
            Console.WriteLine("P = " + dblNum.ToString("P"));
            Console.WriteLine("P1 = " + dblNum.ToString("P1"));
            Console.WriteLine("P2 = " + dblNum.ToString("P2"));
        }

        //what is static non static in c#
        //what is private public protected in c#
        //what is void non void in c#

        static void printArrayNumbers()
        {
            //first parameter is the array holding variable type
            //second parameter is how many dimensions array
            //third parameter is array name
            int[] myIntegerArray = new int[5];
            //here at the right side we have initialize it with new keyword
            //array size can not be changed after initialized

            myIntegerArray[2] = 5;
            myIntegerArray[0] = 7;
            myIntegerArray[1] = 2;
            myIntegerArray[3] = 4;

            Console.WriteLine("first element (0 index) of the array is " + myIntegerArray[0]);
            Console.WriteLine("second element (1 index) of the array is " + myIntegerArray[1]);
            Console.WriteLine("third element (2 index) of the array is " + myIntegerArray[2]);
            Console.WriteLine("fourth element (3 index) of the array is " + myIntegerArray[3]);
            Console.WriteLine("fifth element (4 index) of the array is " + myIntegerArray[4]);
        }

        static void printNumbersAsForLoop()
        {
            Console.WriteLine("below is for loop");

            int[] myIntegerArray = new int[] { 12, 54, 24, 123, 645, 3421, 23 };
            //this composes an array of size 7

            //myIntegerArray[7] = 7; this gives error because array size is 7 and index 7 means 8th element

            for (int i = 0; i < 7; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine((i + 1) + "th element (" + i + 
                    " index) of the array is " + myIntegerArray[i]);
            }
        }

    }
}
