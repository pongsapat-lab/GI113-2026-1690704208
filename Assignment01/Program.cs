namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string gameName = " EX3 SHOWDOWN ";

            var char01_name = "Faust";
            var char01_grade = "C";
            int char01_lvl = 1;
            float char01_atk = 10.7f;
            double char01_def = 5.5;
            bool isPlayerAble = true;


            Console.WriteLine($"    _-={gameName}=-_    ");
            Console.WriteLine($"    | Character: {char01_name} |");
            Console.WriteLine($"    | Grade:     {char01_grade}     |");
            Console.WriteLine($"    | Level:     {char01_lvl}     |");
            Console.WriteLine($"    | Attack:    {char01_atk}  |");
            Console.WriteLine($"    | Defence:   {char01_def}   |");
            Console.WriteLine($"    | Playable:  {isPlayerAble}  |");
            Console.WriteLine("    --------------------");
            Console.WriteLine();
            Console.WriteLine();


            double lvlasDouble = char01_lvl;
            Console.WriteLine($"Level as double (IMPLICIT): {lvlasDouble}");

            int defTruncated = (int)char01_def;               
            int defRounded = Convert.ToInt32(char01_def);
            Console.WriteLine($"Defence cast (TRUNCATES)  : {defTruncated}");
            Console.WriteLine($"Defence convert (ROUNDS)  : {defRounded}");
        }
    }
}
