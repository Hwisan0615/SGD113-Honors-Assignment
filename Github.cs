namespace Github
{
    internal class Program;

namespace Github
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                const int MIN_NUMBER = 1;
                const int MAX_NUMBER = 25;
                const int MAX_ATTEMPTS = 5;


                Console.WriteLine("   Up and Down Game   ");

                Console.WriteLine($"Guess a number between 1 and {MAX_NUMBER}! (You have {MAX_ATTEMPTS} total attempts.)");

                Random random = new Random();
                int target = random.Next(MIN_NUMBER, MAX_NUMBER + 1); // Generate random numbers from 1 to 25
                bool isCorrect = false;

                for (int attempt = 1; attempt <= MAX_ATTEMPTS; attempt++)
                {
                    Console.Write($"{attempt}th attempt: ");
                    if (!int.TryParse(Console.ReadLine(), out int guess) || guess < MIN_NUMBER || guess > MAX_NUMBER)
                    {
                        Console.WriteLine($"Please enter a number between 1 and {MAX_NUMBER}.");
                        attempt--; // Prevent attempts from being deducted
                        continue;
                    }

                    if (guess < target)
                    {
                        Console.WriteLine("up");
                    }
                    else if (guess > target)
                    {
                        Console.WriteLine("down");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! The correct answer is {target}.");
                        isCorrect = true;
                        break;
                    }
                }

                if (!isCorrect)
                {
                    Console.WriteLine($"Too bad! The correct answer was {target}. Try again next time!");
                }
            }
        }
    }

      
}
