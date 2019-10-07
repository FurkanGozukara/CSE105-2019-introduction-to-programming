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

            int irIndex = 0;
            do
            {               
                Console.WriteLine("do while loop: " + lstNumbers[irIndex]);
                //Thread.Sleep(500);
                irIndex++;
                if (irIndex >= lstNumbers.Count)
                    break;
            } while (true);

            Console.Clear();

            irIndex = 0;
            while (true)
            {
                Console.WriteLine("while loop: " + lstNumbers[irIndex]);
               // Thread.Sleep(500);
                irIndex++;
                if (irIndex >= lstNumbers.Count)
                    break;
            }

            Console.Clear();

            irIndex = 0;
            while (irIndex < lstNumbers.Count)
            {
                Console.WriteLine("while loop better: " + lstNumbers[irIndex]);
               // Thread.Sleep(10);
                irIndex++;
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("for loop: " + i);
                Thread.Sleep(500);
                if (i > 111)
                    break;
            }

            irIndex = 0;
            while(irIndex<101)
            {
                Console.WriteLine(irIndex);
                irIndex += 5;
            }

            Console.ReadLine();
        }
    }
}
