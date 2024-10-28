namespace GuessingGame;

class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 7;
        int numberOfTries = 0;

        int userInput = GetuserInput();

        while (userInput != secretNumber)
        {
            if (userInput < secretNumber)
            {
                Console.WriteLine("Too small. Try again.");
                numberOfTries++;
                GetuserInput();
            }
            else if (userInput > secretNumber)
            {
                Console.WriteLine("Too large. Try again.");
                numberOfTries++;
                GetuserInput();
            }
        }
    }

    static int GetuserInput()
    {
        Console.WriteLine("Guess the secret number:");
        string userInputAsString = Console.ReadLine();
        int userInput = Convert.ToInt32(userInputAsString);
        return userInput;
    }
}
