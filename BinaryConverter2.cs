/*Author: Troy Mateo
 * Date: 05/10/2019
 * C# program to convert integers in binary values
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
        }
    }
}
