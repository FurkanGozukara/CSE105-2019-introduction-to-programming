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

            int irK = 0, irM = 0, irI = 0;
            int irDimension_0 = threeDimensonArray.GetLength(0);
            int irDimension_1 = threeDimensonArray.GetLength(1);
            int irDimension_2 = threeDimensonArray.GetLength(2);

            irRow = 1;
            for (; irI < irDimension_0; irI++)
            {
                for (; irK < irDimension_1; irK++)
                {
                    for (; irM < irDimension_2; irM++)
                    {
                        Console.WriteLine(irRow + "\t" + irI + " , " + irK + " , " + irM + " \t" + threeDimensonArray[irI, irK, irM]);
                        irRow++;
                    }
                    irM = 0;
                }
                irK = 0;
            }

            Console.Clear();

            for (int i = 2; i < 100; i = i + 5)
            {
                Console.WriteLine(i);
                i = i + 7;
            }

            //compose an int array length of 100
            //assign to the array numbers between 1-100 in a for loop
            //print array to the screen

            Console.Clear();

            int irArraySize = 250;

            int[] myArray100 = new int[irArraySize];

            for (int i = 0; i < irArraySize; i++)
            {
                myArray100[i] = i + 1;
            }

            for (int i = 0; i < myArray100.GetLength(0); i++)
            {
                Console.WriteLine((i + 1) + " th element is " + myArray100[i]);
            }


            Console.ReadLine();
        }
    }
}
