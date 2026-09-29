/*
 * Student ID : 1690704208
 * Name       : Lab07
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int classID = 1;

            string weapon = classID switch
            {
                1 =>  "Sword",
                2 =>  "Bow",
                3 =>  "Magic",
                _ =>  "Nothing"
            };
        }
    }
}
