namespace TextRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Opening opening = new Opening(); 
            opening.StartGame();
            





            void OldCode()
            {
                Random dice = new Random();

                int heroHP = 10;
                int monsterHP = 10;

                do
                {
                    int roll = dice.Next(1, 11);
                    monsterHP -= roll;
                    Console.WriteLine($"Monster takes {roll} damage, and has {monsterHP} health remaining.");

                    if (monsterHP <= 0)
                        continue;

                    roll = dice.Next(1, 11);
                    heroHP -= roll;
                    Console.WriteLine($"Hero takes {roll} damage, and has {heroHP} health remaining.");
                }
                while (heroHP > 0 && monsterHP > 0);

                Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");
            }
        }
    }

}