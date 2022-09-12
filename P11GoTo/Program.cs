int randomNumber;
int playerGuessI;

Random random = new Random();
randomNumber = random.Next(0, 100) + 1;

Guess:
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
string playerGuess = Console.ReadLine();
playerGuessI = Convert.ToInt32(playerGuess);

if (playerGuessI == randomNumber)
{
    Console.WriteLine("That's the number! Well played!");
}
else if (playerGuessI < randomNumber)
{
    Console.WriteLine("Nope! My number is Greater!");
    goto Guess;
}
else if (playerGuessI > randomNumber)
{
    Console.WriteLine("Nope! My number is Smaller!");
    goto Guess;
}
