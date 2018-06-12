using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("I am getting stronger in coding");
            Console.WriteLine("This scribe will demonstrate so!");
            Console.ReadKey();


            // these are integers
            int Slim = 23;
            int Ford = 100;
            Console.WriteLine(Slim + Ford);
            Console.WriteLine(Ford);
            Console.ReadKey();

            // string interplation 
            var dollars = 4;
           
            Console.WriteLine(String.Format("I have {0} dollars", dollars));
            Console.ReadKey();

            // string interplation with user input 

            Console.Write("Do you like coding? : ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();

           
            // relational operators 
            Console.WriteLine(5 < 90);
            Console.WriteLine("Happy" == "happy");
            Console.WriteLine(-6 > 0);
            Console.WriteLine(1 > 2);
            Console.ReadKey();
        }


    }
    }
