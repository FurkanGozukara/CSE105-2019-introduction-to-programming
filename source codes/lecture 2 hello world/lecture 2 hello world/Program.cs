using System;
using System.Globalization;
using System.Threading;

namespace lecture_2_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string mySchoolName = "Toros University";
            char charA = 'A';
            string letterA = "A";
            Console.WriteLine("Hello World! \t" + charA); //\t is a special character that puts tab
            //this below line is same as above line just explicit conversation
            //in c# only same variable types can be processed
            Console.WriteLine("Hello World! \t" + charA.ToString());
            Console.WriteLine(mySchoolName);
            string myStudentId = "357";
            Console.WriteLine("My student id is " + myStudentId);
            Console.Write("\nFirst day of the school");
            Console.Write("This is the first lesson");
            Console.Write("Manager 'said' \"follow the rules\"");
            Console.WriteLine("1");

            Console.Clear();//this clears the console screen

            int myStudentNumber = 325; //int is 32 bit by default so same as Int32
            Int32 myNationalId = 10001;

            Console.WriteLine("my student number is: " + myStudentNumber);

            Console.WriteLine("my national id is: " + myNationalId);

            Console.WriteLine("sum of my student number and national id is: " + (myStudentNumber + myNationalId));

            Int16 highest16BitNumber = Int16.MaxValue;  //2^15 // 1 bit is saved to represent negative or positive

            string oneZeroRepresentation = Convert.ToString(15, 2);

            Console.WriteLine("15 is represented as " + oneZeroRepresentation + " in binary");

            Console.WriteLine("int 16 is signed 16 bit integer so the maximum value it can take is 2^15 which is " + highest16BitNumber);


            Console.WriteLine(highest16BitNumber + " as binary = " + Convert.ToString(highest16BitNumber, 2));

            Int16 firstNumber = 30000; 
            Int16 secondNumber = -30000;
            UInt16 thirdNumber = UInt16.MaxValue;  //2^16 no bit reserved for the sign

            Console.WriteLine(firstNumber+" as binary = " + Convert.ToString(firstNumber, 2));

            Console.WriteLine(secondNumber+" as binary = " + Convert.ToString(secondNumber, 2));

            Console.WriteLine(thirdNumber + " as binary = " + Convert.ToString(thirdNumber, 2));

            Int16 forthNumber = 15;

            Console.WriteLine(forthNumber + " as 8 base = " + Convert.ToString(forthNumber, 8));

            int fithNumber = int.MaxValue;

            Console.WriteLine(fithNumber + " as 2 base (2^31) = " + Convert.ToString(fithNumber, 2));

            UInt32 number6 = UInt32.MaxValue;

            Console.WriteLine(number6 + " as 2 base (2^32) = " + Convert.ToString(number6, 2));

            Int64 number7 = Int64.MaxValue;

            Console.WriteLine(number7 + " as 2 base (2^63) = " + Convert.ToString(number7, 2));

            double doubleNumber = 101.9876;

            Console.WriteLine(doubleNumber.ToString());

            //CultureInfo ci = new CultureInfo("tr-TR");
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;

            //Console.WriteLine(doubleNumber.ToString());


            double maxDouble = double.MaxValue;

            Console.WriteLine("maxDouble " + maxDouble);

            Console.WriteLine("maxDouble " + String.Format("{0:F20}", maxDouble));


            float floatNumberMax = float.MaxValue;

            Console.WriteLine("floatNumberMax " + floatNumberMax.ToString());

            float floatExample = 3.561F;

            Console.WriteLine("floatExample " + floatExample.ToString());

            decimal maxDecimal = decimal.MaxValue;

            Console.WriteLine("maxDecimal " + maxDecimal.ToString());

            byte byteMax = byte.MaxValue;

            //1 by is 8 bit which means 2^7 maximum for signed

            //1 kybte 1024 * 8 bit = 1 kilo byte

            //1 mb 1024 * 1024 * 8 bit = 1 mega byte

            //1 gb 1024 * 1024 *1024 * 8 bit = 1 giga byte

            //1 tb 1024 * 1024 * 1024 * 1024 * 8 bit = 1 tera byte

            Console.WriteLine("byteMax " + byteMax.ToString());

            bool booleanTrue = true; // this can take 0 or 1 - false true // 1 bit

            Console.WriteLine("booleanTrue " + booleanTrue.ToString());

            Console.WriteLine("booleanTrue as integer " + Convert.ToInt32(booleanTrue));

            char crX = 'Ğ'; //16 bit unicode 

            string srBase16 = "fed83cbc";

            int irBase16 = Convert.ToInt32(srBase16, 16);

            Console.WriteLine("srBase16 "+ srBase16 + " as integer " + irBase16);

            int irValue = 213;

            Console.WriteLine("irValue " + irValue + " as base 16 : " + Convert.ToString(irValue,16));
            //base 16 numbers = 0 1 2 3 4 5 6 7 8 9 a (10) b (11) c (12) d (13) e (14) f (15)
 
            Console.ReadKey();


        }
    }
}
