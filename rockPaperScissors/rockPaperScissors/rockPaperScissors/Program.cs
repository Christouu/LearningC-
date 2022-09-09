class rockPaperScissors
{
    static void Main()
    {
        Random random = new Random();

        bool playAgain = true;
        string player;
        string computer;
        string answer;

        while (playAgain)
        {
            player = "";
            computer = "";
            answer = "";

            while (player != "rock" && player != "paper" && player != "scissors")
            {
                Console.WriteLine("Enter rock, paper or scissors:");
                player = Console.ReadLine();
                player.ToLower();
            }

            int randomNum = random.Next(1, 4);

            switch (randomNum)
            {
                case 1:
                    computer = "rock";
                    break;

                case 2:
                    computer = "paper";
                    break;

                case 3:
                    computer = "scissors";
                    break;

            }

            Console.WriteLine($"\nPlayer {player}\n");
            Console.WriteLine($"Computer {computer}\n");

            switch (player)
            {
                case "rock":
                    if (computer == "rock")
                    {
                        Console.WriteLine("draw");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("Computer wins!");
                    }
                    else
                    {
                        Console.WriteLine("Player wins!");
                    }
                    break;

                case "paper":
                    if (computer == "rock")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("Draw!");
                    }
                    else
                    {
                        Console.WriteLine("Computer wins!");
                    }

                    break;

                case "scissors":

                    if (computer == "rock")
                    {
                        Console.WriteLine("Computer wins!");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("Player wins!");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }
                    break;
            }

            Console.WriteLine("Would you like to play again? (Y/N)\n");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }


        }

        Console.WriteLine("\nThanks for playing!");

        Console.ReadKey();
    }
}