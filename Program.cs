using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicMemoryUnit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int SizeArray = int.Parse(Console.ReadLine());

            // Declare a pointer to an array of integers.
            int[] DinamicArray;

            // Allocate dynamic memory for the array.
            DinamicArray = new int[SizeArray];

            Console.WriteLine($"An array of {SizeArray} elements has been created..");

            // Fill the array with values.
            for (int i = 0; i < SizeArray; i++)
            {
                Console.WriteLine($"Enter the value for element {i}:");
                DinamicArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values of the array are:");
            for (int i = 0; i < SizeArray; i++)
            {
                Console.WriteLine($"Element {i}: {DinamicArray[i]}");
            }

            // Free the dynamic memory when you are done using the array
            DinamicArray = null;

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
