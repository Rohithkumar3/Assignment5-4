using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            // Calculate the sum of elements in the array
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Calculate the average
            double average = (double)sum / numbers.Length;

            // Display sum and average
            Console.WriteLine("Array of random integers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nSum of the elements: " + sum);
            Console.WriteLine("Average of the elements: " + average);

            Console.ReadKey();
        }
            
    }
}
