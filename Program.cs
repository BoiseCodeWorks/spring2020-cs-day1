//NOTE using is the same as Import
using System;
using System.Collections.Generic;
using System.Threading;

//NOTE 
namespace cs_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the Jungle");
            //Primative Data Types

            //Strings & Chars
            //    Implicit typing
            // var name = "Msdfsdf";
            //    Explicit typing
            string name = "Mark";

            //Number (Int (whole numbers), Float (decimal with average accuracy), Decimal (incredibly precise), etc.......)
            var integer = 1;
            var floatVal = 1.34f;
            var decimalVal = 1.2345342342345345m;

            //Boolean
            var x = true;

            //Null / Undefined
            // no such thing as undefined 



            //Control Flow
            //Conditionals
            if (name == "Mark")
            {
                Console.WriteLine("hello " + name);
            }
            else if (name == "Jake")
            {
                Console.WriteLine("greetings " + name);
            }
            else
            {
                Console.WriteLine("hi " + name);
            }

            switch (integer)
            {
                case 1:
                    Console.WriteLine("Number 1");
                    break;
                case 2:
                    Console.WriteLine("Number 2");
                    break;
                default:
                    Console.WriteLine("random?");
                    break;
            }


            //Arrays
            // var names = new string[5];
            // names[0] = "Mark";
            // names[1] = "Bud";
            // names[0] = null;

            string[] choices = new string[]{
                "mark",
                "jake",
                "bud",
                "d$"
            };

            List<string> admin = new List<string>(){
                "Brittany",
                "Zach"
            };
            List<string> instructors = new List<string>(){
                "Mark",
                "Jake",
                "bud"
            };


            admin.Add("Tim");
            admin.Add("d$");
            admin.Remove("d$");

            admin.AddRange(instructors);
            admin.AddRange(choices);

            Console.Clear();

            Console.WriteLine(admin);

            Console.Beep();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("[ ");
            for (int i = 0; i < admin.Count; i++)
            {
                Console.Write(admin[i] + ", ");
            }
            Console.WriteLine(" ]");


            admin.ForEach(e =>
            {
                Console.WriteLine(e);
            });

            string shark = @"
      .            
\_____)\_____
/--v____ __`<         
        )/           
        '
            ";
            Console.WriteLine(shark);
        }
    }
}
