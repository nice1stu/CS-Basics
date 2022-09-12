int randomNumber = Random.Shared.Next(1, 101);

Guess:
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
string playerGuess = Console.ReadLine();
int playerGuessI = Convert.ToInt32(playerGuess);

if (playerGuessI != randomNumber)
{
    Console.WriteLine(playerGuessI < randomNumber ? "Nope! My number is Smaller!" : "Nope! My number is Greater!");
    goto Guess;
}

Console.WriteLine("That's the number! Well played!");