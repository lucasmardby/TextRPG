namespace TextRPG
{
    public class Opening
    {
        public void MainMenu()
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
                        Console.WriteLine("Start!");
                        return;
                    default:
                        Console.WriteLine("Try again, friend. Pick a number.");
                        Helper.ConfirmationButton();
                        break;
                }
            };

        }

        private static void StartScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\tRPG Game".ToUpper());
            Console.WriteLine();
            Console.WriteLine("\t\t\tStart game [1]");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number");
        }

    }
}