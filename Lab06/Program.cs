/*
 * Student ID : 1690704208
 * Name       : Lab06
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 5;

            // call "if" to check
            if (lives == 0) //เงื่อนไขที่เป็น bool
            {
                Console.WriteLine("game over"); //ในปีกกาคือ code ที่จะรันเมื่อมัน true
            }

            //code บรรทัดต่อมาจะทำงานเมื่อ if เสร็จหรือ false
            Console.WriteLine("continue code");
        }
    }
}
