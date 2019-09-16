using System;

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

            int myStudentNumber = 325;
            int myNationalId = 10001;

            Console.WriteLine("my student number is: " + myStudentNumber);

            Console.WriteLine("my national id is: " + myNationalId);

            Console.WriteLine("sum of my student number and national id is: " + (myStudentNumber + myNationalId));

            Console.ReadKey();   
        }   
    }
}
