//Start game
Console.WriteLine("Welcome to Nim!");
Console.WriteLine("How to play");
Console.WriteLine("2 Players");
Console.WriteLine("Players take turns to draw matches");
Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less)");
Console.WriteLine("The Player who has to take last match loses");
Console.WriteLine("Good Luck!");

//Set up game
int startMatches = 24;
int remainingMatches;
int drawPlayer2i;
int drawPlayer1i;
string howMany = " How many matches do you want to draw?";

remainingMatches = startMatches;

/*Game Mechanics:
 players draw 1-3 matches. Cant draw more then remainingMatches. when there is 1 match left, 
 the next player to draw will lose. */

//Players enter name
Console.WriteLine("Player 1, please enter your name");
string player1 = Console.ReadLine();
Console.WriteLine("Player 2, please enter your name");
string player2 = Console.ReadLine();

//Game start
Console.WriteLine("Lets Play !");

for (int i = 0; i < startMatches; i++)
{
    Console.Write("|");
}
Console.WriteLine(remainingMatches); //Fix brackets

//player1 Draw
Console.WriteLine(player1 + howMany);
string drawPlayer1 = Console.ReadLine();
drawPlayer1i = Convert.ToInt32(drawPlayer1);

if (drawPlayer1i > 3)
{
    Console.WriteLine("Please draw between 1 - 3 matches only");
}
// return to drawPlayer1
remainingMatches = startMatches - drawPlayer1i;
for (int i = 0; i < startMatches; i++)
{
    Console.Write("|");
}
Console.WriteLine(remainingMatches); //Fix brackets
startMatches = remainingMatches;

//player2 Draw
Console.WriteLine(player2 + howMany);
string drawPlayer2 = Console.ReadLine();
drawPlayer2i = Convert.ToInt32(drawPlayer2);
if (drawPlayer2i > 3)
{
    Console.WriteLine("Please draw between 1 - 3 matches only");
}
// return to drawPlayer2
remainingMatches = startMatches - drawPlayer2i;
for (int i = 0; i < startMatches; i++)
{
    Console.Write("|");
}
Console.WriteLine(remainingMatches); //Fix brackets
startMatches = remainingMatches;


//Console.WriteLine(drawPlayer1i); check value
//Console.WriteLine(drawPlayer2i); check value