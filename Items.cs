namespace TextRPG
{
    public class Items
    {
        Random random = new Random();
        string startingScroll = "";

        public void StarterItems()
        {
            Console.WriteLine("Choose a starting item.".ToUpper());

            /*
            int roll = random.Next(1,3);
            if (roll == 1) 
            {
                startingScroll = "Scroll of Fire";
            }
            else if (roll == 2)
            {
                startingScroll = "Scroll of Ice";
            }
            */// random scroll

            Console.WriteLine("Scroll of Fire [1],");
            Console.WriteLine("or, Scroll of Ice [2]");

            string menuSelection = "";

            string readResult = Console.ReadLine();
            if (readResult.IsNotNullOrEmpty())
            {
                menuSelection = readResult;
            }

            switch (menuSelection)
            {
                case "1":
                    startingScroll = "Scroll of Fire";
                    break;
                case "2":
                    startingScroll = "Scroll of Ice";
                    break;
                default:
                    Console.WriteLine("Try again, friend. [1] or [2].");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"A great choice, the {startingScroll}.");
            Helper.ConfirmationButton();

            StartingScroll();
        }

        private void StartingScroll()
        {
            OpeningScroll();
            int roll = random.Next(1,3);

            if (startingScroll == "Scroll of Fire")
            { 
                switch (roll) 
                {
                    case 1:
                        Console.WriteLine("[Firebolt], and [Candlelight] have been added to your spellbook.");
                        break;
                    case 2:
                        Console.WriteLine("[Firebolt], and [Catch Flame] have been added to your spellbook.");
                        break;
                }
            }
            else if (startingScroll == "Scroll of Ice")
            {
                switch (roll)
                {
                    case 1:
                        Console.WriteLine("[Frostbolt], and [Ice Nova] have been added to your spellbook.");
                        break;
                    case 2:
                        Console.WriteLine("[Frostbolt], and [Crystallize] have been added to your spellbook.");
                        break;
                }
            }

        }

        private void OpeningScroll()
        {
            Console.WriteLine("Opening the scroll, you find two spells inside.");
        }

    }
}
