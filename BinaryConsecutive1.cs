/*Author: Troy Mateo
 * Date: 05/10/2019
 * C# program to count number of consecutive 1s in a binary number
 */
using System;

namespace BinaryConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Request user input for the desired number they want to convert
            Console.Write("Please enter number to be converted: ");
            string input = Console.ReadLine();

            //Provides variable that will be assigned a value if TryParse is successful
            int number;
            if (int.TryParse(input, out number))
            {

            }
            else
            {
                //Error message if an invalid number is input
                Console.WriteLine("Sorry that wasn't a valid number");
            }

            //Evaluates number to base 2
            string binary = Convert.ToString(number, 2);

            //Prints out the binary result
            Console.WriteLine("Binary: {0}", binary);

            int count = 0;

            //Takes the number input and its actual bit value and performs method body while the value is not equal to 0
            while (number != 0)
            {
                //Uses bitwise operation to shift bit value to the left and logical and operator to change the value
                //count is incremented after this performed and continues to do so until value results to 0
                //The count then has recorded the correct amount of consecutive 1s in the input number
                number = (number & (number << 1));
                count++;
            }

            Console.WriteLine("Number of consecutive 1s is: {0}", count);
         
        }
    }
}

//Output ex:
//Input: 14
//Binary: 1110
//Consec1: 3
//Input: 256
//Binary: 10000000
//Consec1: 1