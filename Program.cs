using System;

namespace MathMethod
{
    class Program
    {
        static void MyMethod(int printTechnique)
        {
            try
            {
                // Print my name to start the solution off
                Console.WriteLine("Jeffery Thurgood");



                // Declare variables for user input and output of arithmetic functions
                int num1 = 6;
                int num2 = 3; 
               
                // declare variables for the output of the operation
                int addition = num1 + num2;
                int subtraction = num1 - num2;
                int multiplication = num1 * num2;
                int division = num1 / num2;

                // Ask user to select the operation they want performed
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("What number operation would you like to perform: ");
                printTechnique = Convert.ToInt32(Console.ReadLine());

                // Perform calculation based on the operation selected
                if (printTechnique == 1)
                {
                
                    Console.WriteLine("the result of adding " + num1 + " and " + num2 + " is:" + addition);
                }
                else if (printTechnique == 2)
                {
                   
                    Console.WriteLine("The result of subtracting " + num1 + " and " + num2 + " is: " + subtraction);
                }
                else if (printTechnique == 3)
                {
                  
                    Console.WriteLine("The result of multiplying " + num1 + " and " + num2 + " is: " + multiplication);
                }
                else if (printTechnique == 4)
                {
                
                    Console.WriteLine("The result of dividing " + num1 + " and " + num2 + " is: " + division);
                }
                else
                {
                    Console.WriteLine("Unrecognized parameter entered: " + printTechnique);
                }
            }
            // Catch the exception of dividing by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by Zero", ex);
            }
        }
        static void Main(string[] args)
        {

            // run operation based off user input
            MyMethod(4);
        }
    }
}
