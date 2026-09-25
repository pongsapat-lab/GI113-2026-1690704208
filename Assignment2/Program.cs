/*
 * Student ID : 1690704208
 * Name       : Assignment #2
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Forge");

            double ironSmelting = 0.25;
            double ironSalvage = 0.3;

            Console.WriteLine("Please choose you action");
            Console.WriteLine("Choose 'S' for smelt"); //(Ore -> Ingot)
            Console.WriteLine("Choose 'B' for breakdown"); //(Ore -> Ingot)

            bool inputAction = int.TryParse(Console.ReadLine(), out int choice);
            Console.WriteLine("And how much do you like: ")
            book inputValue = int.TryParse(Console.ReadLine(), out int value);

            if (!inputAction || choice == s || choice == S || choice == b || choice == B)
            {
                Console.WriteLine("Invalid Input! Please try again!");
            }

            else if (choice == s || choice == S)
            {
                
            }
        }
    }
}
