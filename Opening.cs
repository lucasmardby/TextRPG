namespace TextRPG
{
    public class Opening
    {
        public void StartGame()
        { 
            MainMenu();
            GameOpening();
        }
        private static void StartScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("RPG Game".ToUpper());
            Console.WriteLine();
            Console.WriteLine("\tStart game [1]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter your selection number and press Enter.");
        }
        private static void MainMenu()
        {
            while (true)
            {
                string readResult;
                string menuSelection = "";

                StartScreen();

                readResult = Console.ReadLine();
                if (readResult.IsNotNullOrEmpty())
                {
                    menuSelection = readResult.ToLower();
                }
                switch (menuSelection)
                {
                    case "1":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Try again, friend. Pick a number.");
                        Helper.ConfirmationButton();
                        break;
                }
            };
        }
        private void GameOpening()
        {
            Console.Clear();
            Console.WriteLine("You find yourself by the opening of a cave.");
            Helper.ConfirmationButton();

            /*
            string characterName;
            Console.WriteLine("What is your name?");
            do
            {
                characterName = Console.ReadLine();
                if (characterName.IsNotNullOrEmpty())
                {
                    Console.WriteLine(characterName);
                    return characterName;
                }

            } while (true);
            */ //Name Add


        }

    }
}