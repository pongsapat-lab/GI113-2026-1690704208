/*
 * Student ID : 1690704208
 * Name       : Lab06
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

using System.Reflection.Metadata;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 5;

            //// call "if" to check
            //if (lives <= 0) //เงื่อนไขที่เป็น bool
            //{
            //    Console.WriteLine("game over"); //ในปีกกาคือ code ที่จะรันเมื่อมัน true
            //}
            //else
            //{
            //    Console.WriteLine("pass");
            //}

            ////code บรรทัดต่อมาจะทำงานเมื่อ :if" เสร็จหรือ false
            //Console.WriteLine("continue code");


            //int level = 11;

            //Console.WriteLine("your level (1-99): ");
            //bool inputLevel = int.TryParse(Console.ReadLine(), out int level);
            //bool hasKey = true;

            //if (!inputLevel || level < 1 || level > 99)
            //{
            //    Console.WriteLine("invalid level");
            //}

            //else if (level >= 10 || hasKey)
            //{
            //     Console.WriteLine("boss unlock");
            //}

            //else if (level >= 5)
            //{
            //    if (hasKey)
            //    {
            //        Console.WriteLine("boss unlock");
            //    }
            //    else
            //    {
            //        Console.WriteLine("door lock");
            //    }

            //}

            //else
            //{
            //    Console.WriteLine("door stay shut");
            //}

            //bool isPoisioned = true;

            //if (isPoisioned == true)
            //{
            //    Console.WriteLine("dead");
            //}
            //else if (!isPoisioned == false) 
            //{
            //    Console.WriteLine("lived");
            //}

            int pcHp = 100;
            int targetHp = 20;
            int attack = 10;
            int defence = 10;
            int heal = 2;
            int target_atk = 15;

            Console.WriteLine("Hero versus Monster");

            Console.WriteLine("Action 1: Attack");
            Console.WriteLine("Action 2: Defence");
            Console.WriteLine("Action 3: Heal");

            Console.WriteLine("Choose your action (1-3): ");
            bool inputAction = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputAction || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid Value!");
            }
            else if (choice == 1)
            {
                targetHp -= attack;
                if (targetHp <= 0)
                {
                    Console.WriteLine($"Target take {attack} DMG, Target taking out");
                }
                else
                {
                    Console.WriteLine($"Target take {attack} DMG, Target has {targetHp} hp left");
                }
            }

            else if (choice == 2)
            {
                pcHp -= target_atk - defence;
                if (pcHp <= 0)
                {
                    Console.WriteLine($"Player rise guard and take {target_atk} DMG, Player taking out");
                }
                else
                {
                    Console.WriteLine($"Player rise guard and take {target_atk} DMG, Player has {pcHp} left");
                }

            }
            else
            {
                pcHp += heal;
                Console.WriteLine($"Player use heal, now Player has {pcHp} HP left");
            }
        }
    }
}
