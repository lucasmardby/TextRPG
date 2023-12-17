namespace TextRPG
{
    public class Items
    {
        Random random = new Random();
        string startingScroll = "";

        public void StarterItems()
        {
            Console.WriteLine("Choose a starting item.".ToUpper());
            Console.WriteLine("Scroll of Fire [1],");
            Console.WriteLine("or, Scroll of Ice [2]");
            
            do
            {
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
                        FireScroll();
                        break;
                    case "2":
                        startingScroll = "Scroll of Ice";
                        IceScroll();
                        break;
                    default:
                        Console.WriteLine("Try again, friend. [1] or [2].");
                        break;
                }
            } while (startingScroll == "");
        }

        private void FireScroll()
        {
            OpeningScroll();
            SpellBook spellBook = new SpellBook();

            int roll = random.Next(1, 3);
            string spellOne = "";
            string spellTwo = "";

            switch (roll)
            {
                case 1:
                    spellOne = "Firebolt";
                    spellTwo = "Candlelight";
                    break;
                case 2:
                    spellOne = "Firebolt";
                    spellTwo = "Catch Flame";
                    break;
            }
            spellBook.currentSpells.Add(spellOne);
            spellBook.currentSpells.Add(spellTwo);
            Console.WriteLine($"{spellOne}, and {spellTwo} have been added to your spellbook.");
        }

        private void IceScroll() 
        {
            OpeningScroll();
            SpellBook spellBook = new SpellBook();

            int roll = random.Next(1, 3);
            string spellOne = "";
            string spellTwo = "";

            switch (roll)
            {
                case 1:
                    spellOne = "Frostbolt";
                    spellTwo = "Ice Nova";
                    break;
                case 2:
                    spellOne = "Frostbolt";
                    spellTwo = "Crystallize";
                    break;
            }
            spellBook.currentSpells.Add(spellOne);
            spellBook.currentSpells.Add(spellTwo);
            Console.WriteLine($"{spellOne}, and {spellTwo} have been added to your spellbook.");
        }

        private void OpeningScroll()
        {
            Console.WriteLine();
            Console.WriteLine($"A great choice, the {startingScroll}.");
            Helper.ConfirmationButton();
            Console.WriteLine("Opening the scroll, you find two spells inside.");
        }

    }
}
