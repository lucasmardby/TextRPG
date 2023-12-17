namespace TextRPG
{
    public class Boss
    {
        Random random = new Random();

        public void BossRandomizer()
        {
            int roll = random.Next(1, 3);

            switch (roll)
            {
                case 1:
                    FirstBoss();
                    break;
                case 2:
                    SecondBoss();
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void FirstBoss()
        {
            Console.WriteLine("First Boss");
        }
        private void SecondBoss()
        {
            Console.WriteLine("Second Boss");
        }

    }
}
