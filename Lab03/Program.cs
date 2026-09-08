using System.Collections;

namespace Lab03
{

    /*
    * Student ID : 1690704208
    * Name       : Lab03
    * Section    : 129D
    * No.        : 
    * Course     : GI113 Computer Programming (GI)
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Levle: {level} / {MaxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");
            Console.WriteLine();

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {hpPercentExact}%");
            Console.WriteLine();

            Console.WriteLine("-----Explicit Cast: Attack Power->Display Int----");
            int castPower = (int)attackPower;
            Console.WriteLine($"Attack Power(int cast): {castPower}");
            Console.WriteLine();

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int castCrit = (int)critMultiplier;
            Console.WriteLine($"Crit Multiplier (int cast): {castCrit}");
            Console.WriteLine("Crit Multiplier (Convert rounded): " + Convert.ToInt32(critMultiplier));
            Console.WriteLine();









        }
    }
}
