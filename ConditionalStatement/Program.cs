using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to enter a grade percentage they expect to get in their class 
            Console.WriteLine("What grade percentage do you expect in ISM 4300? ");

            {
                String GradeInput = Console.ReadLine();

                //Converts the string input of the grade percentage to a decimcal value 
                decimal Grade = decimal.Parse(GradeInput);

                //If statement used to figure out the letter grade the user has 
                if (Grade >= 98)
                {
                    Console.WriteLine("A+");
                }
                //Else if statments used if the first if statment doesn't match the user request
                else if (Grade >= 92)
                {
                    Console.WriteLine("A");
                }
                else if (Grade >= 90)
                {
                    Console.WriteLine("A-");
                }
                else if (Grade >= 88)
                {
                    Console.WriteLine("B+");
                }
                else if (Grade >= 82)
                {
                    Console.WriteLine("B");
                }
                else if (Grade >= 80)
                {
                    Console.WriteLine("B-");
                }
                else if (Grade >= 78)
                {
                    Console.WriteLine("C+");
                }
                else if (Grade >= 72)
                {
                    Console.WriteLine("C");
                }
                else if (Grade >= 70)
                {
                    Console.WriteLine("C-");
                }
                else if (Grade >= 68)
                {
                    Console.WriteLine("D+");
                }
                else if (Grade >= 62)
                {
                    Console.WriteLine("D");
                }
                else if (Grade >= 60)
                {
                    Console.WriteLine("D-");
                }
                //Else statment used if none of the if and else if statments work with the user request 
                else
                {
                    Console.WriteLine("F");
                }
            }  
        }
    }
}
