using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecture_5_for_foreach_while
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("for loop: " + i);
                //Thread.Sleep(500);
            }
            Console.Clear();

            List<int> lstNumbers = new List<int>();
            lstNumbers.AddRange(Enumerable.Range(1, 100));

            //this below equals to above code
            //for (int i =1; i < 101; i++)
            //{
            //    lstNumbers.Add(i);
            //}

            foreach (var vrNumber in lstNumbers)
            {
                Console.WriteLine("foreach loop: " + vrNumber);
                //Thread.Sleep(500);
            }

            do
            {
                int irIndex = 0;
                Console.WriteLine("do while loop: " + lstNumbers[irIndex]);
                Thread.Sleep(500);
                irIndex++;
                if (irIndex >= lstNumbers.Count)
                    break;
            } while (true);

            Console.ReadLine();
        }
    }
}
