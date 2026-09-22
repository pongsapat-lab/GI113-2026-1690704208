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


            int level = 11;

            if (level >= 10)
            {
                Console.WriteLine("boss unlock");
            }
            else if (level >= 5)
            {
                Console.WriteLine("door opne");
            }
            else
            {
                Console.WriteLine("door stay shut");
            }

            bool isPoisioned = true;

            if (isPoisioned == true)
            {
                Console.WriteLine("dead");
            }
            else if (!isPoisioned == false) 
            {
                Console.WriteLine("lived");
            }

        }
    }
}
