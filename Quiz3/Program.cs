using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialize variable to hold values for multiple iterations
            string inputST = "";
            string exit = "exit";
            bool isPalindrome = true; 
            //Title
            Console.WriteLine("CHECK PALINDROME");
            Console.WriteLine(""); //Divides space between title and prompt
            do
            {
                //Prompts user for a string
                Console.Write("Enter a string:");
                //Declares user input as variable and store in memory
                inputST = Console.ReadLine();

                Console.WriteLine(""); //Divides space between prompts
                //Check characters in string to match
                for (int i = 0; i < inputST.Length; i++)
                { 
                    if (inputST[i] = inputST(inputST.Length-1))
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                //Outputs if string is palindrome
                if (isPalindrome == true)
                {
                    Console.WriteLine($"Result: {inputST} is a palindrome.");
                }
                //Outputs if string is palindrome
                else
                {
                    Console.WriteLine($"Result: {inputST} is not a palindrome.");
                }
                Console.WriteLine(""); //Divides space between prompts
                Console.WriteLine(""); //Divides space between prompts

                //Prompts user for a string
                Console.Write("Enter a string:");
                //Declares user input as variable and store in memory
                inputST = Console.ReadLine();
            } while (inputST != exit);
            Console.WriteLine("Bye!");
        }
    }
}
