using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_the_max
{
    class Program
    {
        static void Main(string[] args)

        {


            try
            {

                Doit();
           
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
                Doit();
            }
            Console.ReadKey();
        }

        static void Doit()
        {

            double firstNum, secNum, thirdNum, fourthNum, fifthNum;

            //prompt user to input 5 numbers
            Console.WriteLine("Enter the first number: ");
            firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            fourthNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth number: ");
            fifthNum = double.Parse(Console.ReadLine());

            //create an empty array
            double[] emptyArray = new double[5] { firstNum, secNum, thirdNum, fourthNum, fifthNum };


            // cycle through the array to find the largest number

            //foreach (double x in emptyArray)
            //{
            //    if ( x >)
            //}


            double max = emptyArray.Max();
            //print to the console that number 
            Console.WriteLine($"The largest number in that array is {max}");

        }


    }
}
