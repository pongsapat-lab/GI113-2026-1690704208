namespace LAB04
{

    /*
    * Student ID : 1690704208
    * Name       : Lab04
    * Section    : 129D
    * No.        : 
    * Course     : GI113 Computer Programming (GI)
    */

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
            Console.WriteLine();


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|       DIFFICULTY SELECT      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Choose difficulty (1-3): ");
            bool diffcultyOk = int.TryParse(Console.ReadLine(), out int diffculty);
            //int diffculty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Valid input: {diffculty}");
            Console.WriteLine($"\n\"Diffculty{diffculty} selected. Good luck out there...");
            Console.WriteLine();


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();



            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine();


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          RATE THIS LEVLE     |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Rate this level (0.0-5.0): ");
            bool rateOk = double.TryParse(Console.ReadLine(), out double rate);
            Console.WriteLine($"Valid input: {rateOk}");
            Console.WriteLine($"Rate: {rate}");
            Console.WriteLine($"Thank you for rating!");
            Console.WriteLine();


            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE        |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");


        }
    }
}
