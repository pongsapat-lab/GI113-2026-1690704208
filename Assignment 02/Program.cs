/*
* Student ID : 1690704208
* Name       : Assignment #2
* Section    : 129D
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string itemName = "Iron";
            const double ironSmelting = 0.25;
            const double ironSalvage = 0.3;
            const int MaxBatch = 500;

            Console.WriteLine("Welcome to the Forge");
            Console.WriteLine("Please choose you action");
            Console.WriteLine("Choose 'S' for smelt"); //(Ore -> Ingot)
            Console.WriteLine("Choose 'B' for breakdown"); //(Ore -> Ingot)
            bool inputAction = char.TryParse(Console.ReadLine(), out char choice); //เลือกงาน

            Console.WriteLine("And how much do you like: ");
            bool inputValue = int.TryParse(Console.ReadLine(), out int value); //จำนวนที่ใส่


            if (inputValue || value > 0 || value <= MaxBatch)
            {

                if (inputAction && (choice == 's' || choice == 'S'))
                {
                    double result = value * ironSmelting;
                    Console.WriteLine($"{value:F2} Iron ore = {result:F2} Iron bar");
                }

                else if (inputAction && (choice == 'b' || choice == 'B'))
                {
                    double result = value / ironSalvage;
                    Console.WriteLine($"{value:F2} Iron bar = {result:F2} Iron ore");
                }

                else
                {
                    Console.WriteLine("Invalid Action! Please try again!");
                }

            }
            else
            {
                Console.WriteLine("Invalid value! Please try again!");
            }
        }
    }
}
