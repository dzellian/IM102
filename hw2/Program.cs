using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
                // Ask for rows and columns
                Console.Write("Enter row: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Enter col: ");
                int cols = int.Parse(Console.ReadLine());

                // List to hold numbers
                List<double> numbers = new List<double>();

                // Input values row by row
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine($"Row {i + 1}");
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Enter number{j + 1}: ");
                        double num = double.Parse(Console.ReadLine());
                        numbers.Add(num);
                    }
                }

                Console.WriteLine("\nThe numbers are:");
                int index = 0;
                double sum = 0;

                // Print matrix and compute sum
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(numbers[index] + " ");
                        sum += numbers[index];
                        index++;
                    }
                    Console.WriteLine();
                }

                // Calculate average
                double average = sum / numbers.Count;

                Console.WriteLine($"\nSum: {sum} ; Average: {average}");
            Console.ReadKey();
            }
        }

    }


