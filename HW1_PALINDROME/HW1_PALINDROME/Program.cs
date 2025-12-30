using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_PALINDROME
{
    class Program
    {
        static void Main(string[] args)
        {

            //   static void Main()
            {
                while (true)
                {
                    Console.Write("Enter string: ");
                    string input = Console.ReadLine();

                    if (input == "*")
                    {
                        Console.WriteLine("//End execution");
                        break;
                    }

                    string original = input;
                    string lowerInput = input.ToLower();

                    // Build reversed string manually
                    string reversed = "";
                    for (int i = lowerInput.Length - 1; i >= 0; i--)
                    {
                        reversed += lowerInput[i];
                    }

                    // Check palindrome manually
                    bool isPalindrome = true;
                    for (int i = 0; i < lowerInput.Length; i++)
                    {
                        if (lowerInput[i] != reversed[i])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    // Display result
                    Console.WriteLine("\nOriginal String \t    Reversed String \t    Palindrome?");
                    Console.WriteLine(" " + original + "\t\t           " + reversed + "\t          " + (isPalindrome ? "Yes" : "No") + "\n");
                }
            }
        }
    }
}


