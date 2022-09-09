class Program
{
    static void Main()
    {

        Random random = new Random();

        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        string response = "";

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine($"Guess a number between {min} - {max}");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Guess: {guess}");

                if (guess > number)
                {
                    Console.WriteLine($"{guess} is too high!");

                }
                else if (guess < number)
                {
                    Console.WriteLine($"{guess} is too low!\n");

                }
                guesses++;
            }

            Console.WriteLine($"{guess} is the right number!\n");
            Console.WriteLine($"Needed tries: {guesses}\n");

            Console.WriteLine("Do you want to play again? (Y/N): ");
            response = Console.ReadLine();
            response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!\n");

        Console.ReadKey();
    }
}
