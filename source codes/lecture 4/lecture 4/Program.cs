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
            int[] singleDimensionArray2 = new int[] { 42, 123, 45, 21, 66, 23, 111, 345 };
            Console.WriteLine(singleDimensionArray[30]);
            Console.WriteLine(singleDimensionArray2[0]);

            string[] stringArray = new string[22];
            Console.WriteLine(stringArray[5]);//this works because writeline handles null values
            //Console.WriteLine(stringArray[5].ToString());//this throws error because tostring method does not handle null values

            int[,] twoDimensionArray = new int[2, 4];
            twoDimensionArray[1, 2] = 3;

            int[,] twoDimensionArray2 = new int[,] { { 32, 12, 0, 0 }, { 44, 21, 4, 12 } };
            //8 is the length of first dimension index 0
            //5 is the length of second dimension index 1
            //7 is the length of third dimension index 2
            int[,,] threeDimensonArray = new int[8, 5, 7];

            threeDimensonArray[2, 3, 1] = 6;
            threeDimensonArray[3, 2, 2] = 3;
            threeDimensonArray[4, 1, 6] = 3;

            int irRow = 1;

            for (int i = 0; i < threeDimensonArray.GetLength(0); i++)
            {
                //for (int k = 0; k < 5; k++) same as below
                for (int k = 0; k < threeDimensonArray.GetLength(1); k++)
                {
                    for (int m = 0; m < threeDimensonArray.GetLength(2); m++)
                    {
                        Console.WriteLine(irRow + "\t" + i + " , " + k + " , " + m + " \t" + threeDimensonArray[i, k, m]);
                        irRow++; // irRow = irRow + 1; // irRow += 1; // all means same
                    }
                }
            }

            Console.Clear();

            Console.WriteLine("the length of the first dimension is : " + threeDimensonArray.GetLength(0));
            Console.WriteLine("the length of the second dimension is : " + threeDimensonArray.GetLength(1));
            Console.WriteLine("the length of the third dimension is : " + threeDimensonArray.GetLength(2));

            Console.ReadLine();
        }
    }
}
