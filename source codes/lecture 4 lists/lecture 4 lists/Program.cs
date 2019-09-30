using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_4_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstMyNumbers = new List<int> { 32, 12 };
            lstMyNumbers.Add(34);
            lstMyNumbers.Add(42);

            foreach (var vrNum in lstMyNumbers)
            {
                Console.WriteLine(vrNum);
            }

            lstMyNumbers.Remove(34);//removes 34

            lstMyNumbers.RemoveAt(0);//removes 32

            lstMyNumbers.AddRange(new List<int> { 66, 77, 11 });

            lstMyNumbers.Add(99);

            Console.WriteLine();

            foreach (var vrNum in lstMyNumbers)
            {
                Console.WriteLine(vrNum);
            }
            //change third number to number 55 before
            //also print this with for loop as well

            Console.Clear();

            lstMyNumbers[2] = 55;
            //make arrays of arrays next lesson
            for (int i = 0; i < lstMyNumbers.Count; i++)
            {
                Console.WriteLine(lstMyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
