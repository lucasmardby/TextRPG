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
            Console.WriteLine("Start game [1]");
            Console.WriteLine("Test function (BossRandomizer) [9]");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number and press Enter.");
        }
        private static void MainMenu()
        {
            while (true)
            {
                string menuSelection = "";

                StartScreen();

                string readResult = Console.ReadLine();
                if (readResult.IsNotNullOrEmpty())
                {
                    menuSelection = readResult;
                }
                switch (menuSelection)
                {
                    case "1":
                        Console.Clear();
                        return;
                    case "9":
                        Boss boss = new Boss();
                        boss.BossRandomizer();
                        Helper.ConfirmationButton();
                        break;
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
            */ //Character Name??

            Items items = new Items();
            items.StarterItems();

            Boss boss = new Boss();
            //boss.BossRandomizer();





        }


        private void LogoTest()
        {
            /*
                              _                 _
                     /\      | |               | |                 
                    /  \   __| |_   _____ _ __ | |_ _   _ _ __ ___ 
                   / /\ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
                  / ____ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/
                 /_/    \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|


                */
        }

    }
}