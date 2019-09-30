using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] singleDimensionArray = new int[32];
            int[] singleDimensionArray2 = new int [] { 42, 123, 45, 21, 66, 23, 111, 345 };
            Console.WriteLine(singleDimensionArray[30]);
            Console.WriteLine(singleDimensionArray2[0]);

            string[] stringArray = new string[22];
            Console.WriteLine(stringArray[5]);//this works because writeline handles null values
            //Console.WriteLine(stringArray[5].ToString());//this throws error because tostring method does not handle null values

            int[,] twoDimensionArray = new int[2, 4];

            Console.ReadLine();
        }
    }
}
