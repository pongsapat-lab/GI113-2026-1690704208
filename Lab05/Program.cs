/*
 * Student ID : 1690704208
 * Name       : Lab05
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== BATTLE ARENA ===");
            Console.WriteLine("Hero vs Monster -- Fight Damage Calculator");

            //Hero
            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);  //HeEro HP 35 
            Console.Write("Hero Attack: ");
            bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAttack);  //Hero Atk 14
            Console.Write("Hero Defense: ");
            bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDefense); //Hero Def 3
            Console.WriteLine();

            //Mon
            Console.Write("Monster HP: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp); //Mon HP 45
            Console.Write("Monster Attack: ");
            bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monsterAttack); //Mon Atk 11
            Console.Write("Monster Defense: ");
            bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monsterDefense); //Mon Def 4
            Console.WriteLine();

            //input validation / output
            bool heroStatsValid = heroHpOk && heroAttackOk && heroDefenseOk;
            bool monsterStatsValid = monsterHpOk || monsterAttackOk || monsterDefenseOk;
            Console.WriteLine($"\nHero stats valid: {heroStatsValid}");
            Console.WriteLine($"Monster stats valid: {monsterStatsValid}");
            Console.WriteLine();

            int monsterMaxHp = monsterHp;
            Console.WriteLine($"[Hero]    HP:{heroHp} ATK:{heroAttack} DEF:{heroDefense}");
            Console.WriteLine($"[Monster] HP:{monsterHp} ATK:{monsterAttack} DEF:{monsterDefense}");
            Console.WriteLine();
            Console.WriteLine();


            // Before scouting: Hero drinks a potion (compound assignment: +=) กินยาก่อนสู้
            int potionHeal = 8;

            heroHp += potionHeal; //สั้น
            //herohp = herohp + potionHeal ยาว
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal}. Hero HP is now {heroHp}.");

            // Damage preview 1: Normal Attack (arithmetic + Math -- the base pattern)
            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal Attack would deal: {normalDamage} damage");

            // Damage preview 2: Power Attack (precedence -- multiply before subtract)
            int powerDamage = Math.Max(0, heroAttack * 2 - monsterDefense);
            Console.WriteLine($"Power Attack would deal: {powerDamage} damage");

            // Damage preview 3: what Monster would deal back, if it got a turn (same pattern, other side)
            int counterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"If Monster counters afterward, it would deal: {counterDamage} damage");
            Console.WriteLine();
            Console.WriteLine();


            Random rng = new Random(14);
            int roll = rng.Next(1, 101);
            bool isCritical = roll <= 10;
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"If critical, Normal Attack would instead deal: {criticalDamage} damage");
            Console.WriteLine();
            Console.WriteLine();


            bool heroHitsHarder = heroAttack > monsterAttack;
            bool canOneShotWithNormal = normalDamage >= monsterHp;
            bool monsterCanOneShotHero = counterDamage >= heroHp;
            bool safeTrade = normalDamage > counterDamage && !monsterCanOneShotHero;
            bool luckyOrLethal = isCritical || canOneShotWithNormal;
            Console.WriteLine($"Hero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {canOneShotWithNormal}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterCanOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");
            Console.WriteLine();
            Console.WriteLine();


            // Hero commits to the Normal Attack (compound assignment: -=)
            monsterHp -= normalDamage;
            Console.WriteLine($"Hero attacks! Monster HP: {monsterHp}/{monsterMaxHp}");

            // Result + reward
            bool monsterDefeated = monsterHp <= 0;
            int goldEarned = (monsterMaxHp - monsterHp) * 2;
            Console.WriteLine($"Monster defeated: {monsterDefeated}");
            Console.WriteLine($"Gold earned: {goldEarned}");

        }
    }
}
