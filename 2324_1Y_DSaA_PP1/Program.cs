using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_DSaA_PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration step
            string uInput = ""; // this variable will be holding all the user inputs
            char fChar = ' '; // this variable will be holding the first character input
            char sChar = ' '; // this variable will be holding the second character input
            int ope = -1; // this variable will beholding which operation will be performed

            // this is the user instruction block
            Console.WriteLine("This is a different kind of calculator.");
            Console.WriteLine("This calculator performs mathematical operations on the ASCII decimal numbers.");
            
            // this while loop will be for error checking
            while(true) 
            {
                Console.Write("\nPlease input the first character you wish to use: ");
                uInput = Console.ReadLine(); // this will take the user input
                if(uInput.Length == 1) // this will check if the length of the user input is 1 character long
                {
                    fChar = uInput[0]; // this will convert the string to a character
                    Console.WriteLine($"'{fChar}' is accepted."); // this just informs the user that the character has been accepted
                    break; // this breaks the while loop
                }
                else
                {
                    // this block will just inform the user that the input is too long or blank.
                    Console.WriteLine("Input is invalid. Input is either too long or too short. Please only input one character.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            // this while loop will be for error checking
            while (true)
            {
                Console.Write("\nPlease input the second character you wish to use: ");
                uInput = Console.ReadLine(); // this will take the user input
                if (uInput.Length == 1) // this will check if the length of the user input is 1 character long
                {
                    sChar = uInput[0]; // this will convert the string to a character
                    Console.WriteLine($"'{sChar}' is accepted."); // this just informs the user that the character has been accepted
                    break; // this breaks the while loop
                }
                else
                {
                    // this block will just inform the user that the input is too long or blank.
                    Console.WriteLine("Input is invalid. Input is either too long or too short. Please only input one character.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            // this while loop will be for error checking
            // the loop will check if ope is -1
            // ope being -1 means that no operation has been selected
            while (ope == -1)
            {
                // instruction to the user on what to do for this section
                Console.WriteLine("\nPlease select the operation you wish to perform.");
                Console.WriteLine("[A] Addition\n[B] Subtraction\n[C] Multiplication\n[D] Division");
                Console.Write("Selected operation: ");
                uInput = Console.ReadLine().ToLower(); // asks the user for input but converts it to lower case
                if (uInput.Length == 1) // this will check if the length of the user input is 1 character long
                {
                    // this formula will convert the string to a char
                    // then convert it to int and then subtract 97 to that value
                    ope = (int)uInput[0] - 97; 
                    if (ope > -1 && ope < 4) // if the operation is between 0 and 3
                    {
                        break; // stops the while loop
                    }
                    else
                    {
                        // instructions to the user
                        Console.WriteLine("Input is invalid. Input not amongst the choices.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        // resets ope to -1
                        ope = -1;
                    }
                }
                else
                {
                    // instructions to the user
                    Console.WriteLine("Input is invalid. Input is either too long or too short. Please only input one character.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            // switch case based on operation
            switch(ope)
            {
                case 0:
                    Console.WriteLine("\nAddition is being performed.");
                    Console.WriteLine($"Character\t\t:\t{fChar} + {sChar}"); // this line displays the characters and the operation selected
                    Console.WriteLine($"Number converted\t:\t{(int)fChar} + {(int)sChar}"); // this converts the characters to int and displays it
                    Console.WriteLine($"Computation\t\t:\t{(int)fChar + (int)sChar}"); // just performs the operation on the converted characters
                    break;
                case 1:
                    Console.WriteLine("\nSubtraction is being performed.");
                    Console.WriteLine($"Character\t\t:\t{fChar} - {sChar}"); // this line displays the characters and the operation selected
                    Console.WriteLine($"Number converted\t:\t{(int)fChar} - {(int)sChar}"); // this converts the characters to int and displays it
                    Console.WriteLine($"Computation\t\t:\t{(int)fChar - (int)sChar}"); // just performs the operation on the converted characters
                    break;
                case 2:
                    Console.WriteLine("\nMultiplication is being performed.");
                    Console.WriteLine($"Character\t\t:\t{fChar} * {sChar}"); // this line displays the characters and the operation selected
                    Console.WriteLine($"Number converted\t:\t{(int)fChar} * {(int)sChar}"); // this converts the characters to int and displays it
                    Console.WriteLine($"Computation\t\t:\t{(int)fChar * (int)sChar}"); // just performs the operation on the converted characters
                    break;
                case 3:
                    Console.WriteLine("\nDivision is being performed.");
                    Console.WriteLine($"Character\t\t:\t{fChar} / {sChar}"); // this line displays the characters and the operation selected
                    Console.WriteLine($"Number converted\t:\t{(int)fChar} / {(int)sChar}"); // this converts the characters to int and displays it
                    Console.WriteLine($"Computation\t\t:\t{(float)fChar / (float)sChar}"); // just performs the operation on the converted characters
                    break;
            }
            // instructions to the user
            Console.WriteLine("Calculation complete.");
            Console.ReadKey();
        }
    }
}
