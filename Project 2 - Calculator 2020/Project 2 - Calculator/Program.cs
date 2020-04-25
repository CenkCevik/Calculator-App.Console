using System;
using System.Linq;
using System.Drawing;

namespace Project_2___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   // Variables for calculator operator, numbers and answer.
            string operation;
            double firstNumber;
            double secondNumber;
            double answer;
            // Bool, this is used at the end if user clicks 'yes' calculation while loop will start again.
            bool anotherOperation = true;

            while (anotherOperation)
            {   // Message to user Welcoming and giving instructions, is spaced out.
                Console.WriteLine(" ");
                Console.WriteLine("\t\t\t\t\tWelcome to the Calculator App!\r");
                Console.WriteLine("\t\t\t\t\t------------------------------------------------");
                Console.WriteLine("\t\t\t\t\tPlease choose one of the following (+,-,*,/,%)?\r");
                Console.WriteLine("\t\t\t\t\t------------------------------------------------");
                Console.ResetColor();
                // Reads input.
                operation = Console.ReadLine();
                // If user enters correct input, it is displayed in green.
                // If not correct input message displayed in red, will repeat.
                while (true)
                {   
                    if (operation == ("+") || operation == ("-") || operation == ("*") || operation == ("/") || operation == ("%"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + operation);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("The +,- and / operators take a maximum of 14 digits for each number.");
                        Console.WriteLine("The * operator takes a maximum of 7 digits for each number.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid operator!");
                        Console.WriteLine("Please try again!");
                        Console.ResetColor();
                        operation = Console.ReadLine();
                    }
                }
                // If operation is + whole calulation can be complete here.
                if (operation == "+")
                {   // Asks for user to input number.
                    Console.WriteLine("Enter the (FIRST NUMBER) ... then press (Enter)");
                    // If number is assigned to variable, user is asked next question.
                    if (double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    else
                    {   // Repeats question in red if input is incorrect. 
                        // Breaks, assignes value and asks second question if correct answer.
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();
                        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    // If variable number is assigned to second number, calculation will commence.
                    if (double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber + secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                    else
                    {   // If input is not a number question repeats. Breaks when number entered.
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out secondNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        // Calculates the two numbers and displays it.
                        answer = firstNumber + secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        // Bool set to false, is used later to enable re-calculation.
                        anotherOperation = false;
                    }
                } // The Minus, Times and Divide operator statements are run the same as Plus statement. 
                else if (operation == "-")
                {
                    Console.WriteLine("Enter the (FIRST NUMBER) ... then press (Enter)");

                    if (double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }

                    if (double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber - secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out secondNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber - secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                }
                else if (operation == "*")
                {
                    Console.WriteLine("Enter the (FIRST NUMBER) ... then press (Enter)");

                    if (double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }

                    if (double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber * secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out secondNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber * secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                }
                else if (operation == "/")
                {
                    Console.WriteLine("Enter the (FIRST NUMBER) ... then press (Enter)");

                    if (double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out firstNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }

                    if (double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber / secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                    else
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out secondNumber));

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        answer = firstNumber / secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                }
                else if (operation == "%")
                {   // Gives instructions on how to calculate %.
                    Console.WriteLine("First Number is (%) of Second Number");
                    Console.WriteLine("E.g. (First number= 50%) of (Second Number=40)");
                    Console.WriteLine("Answer= 20");
                    Console.WriteLine("Enter the (FIRST NUMBER) ... then press (Enter)");
                    // Checks that user enters a number in vaiable.
                    if (double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber + "% OF");
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    else
                    {   // Will repeat question if incorrect input.
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out firstNumber));
                        // Asks for next value if input is correct.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + firstNumber + "% OF");
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        Console.WriteLine("Enter the (SECOND NUMBER) ... then press (Enter)");
                    }
                    // Checks value for second number is a number.
                    if (double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        firstNumber = firstNumber / 100;
                        answer = firstNumber * secondNumber;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                    else
                    {   // Repeats question if number is not entered.
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid input, please try again!");
                            Console.ResetColor();

                        } while (!double.TryParse(Console.ReadLine(), out secondNumber));
                        // Calculates the percentage and display's answer if input is correct.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + secondNumber);
                        Console.WriteLine("\t\t\t\t\t\t---------------");
                        Console.ResetColor();
                        firstNumber = firstNumber / 100;
                        answer = firstNumber * secondNumber; Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\tAnswer = " + answer);
                        Console.ResetColor();
                        anotherOperation = false;
                    }
                }
                // Asks user if they would like to re-calculate. 
                // Assigns user input to string.
                Console.WriteLine("Would you like to try another calculation?");
                Console.WriteLine("Y/N ... then press (Enter)?");
                string nextTask = Console.ReadLine();

                while (true)
                {   // If assigned value is acceptable answer below, the above while loop which allows...
                    // calculations to occur will loop. If user chooses message will display allowing user to exit.
                    if (nextTask == ("Y") || nextTask == ("y"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + nextTask);
                        Console.ResetColor();
                        anotherOperation = true;
                        break;
                    }
                    else if (nextTask == ("N") || nextTask == ("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t\t\t\t\t\t\t" + nextTask);
                        Console.ResetColor();
                        anotherOperation = false;
                        break;
                    }// Repeats question until valid operation is entered.
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid operator!");
                        Console.WriteLine("Please try again!");
                        Console.ResetColor();
                        nextTask = Console.ReadLine();
                    }
                }
            }   
            // Displays a 'thank you' message and explains how user can exit. 
            Console.WriteLine("\t\t\t\t\t\t---------------");
            Console.WriteLine("\t\t\t\t\t\tThan you for using the App!");
            Console.WriteLine("\t\t\t\t\t\tPress enter to exit : )");
            Console.WriteLine("\t\t\t\t\t\t---------------");
        }
    }
}
