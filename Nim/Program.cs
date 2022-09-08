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
int drawPlayer2I;
int drawPlayer1I;
int matchesDrawn = 0; // sets how many matches drawn to check
string currentPlayer;
string howMany = " How many matches do you want to draw?";

remainingMatches = startMatches;

/*void drawMatches
{
    Console.WriteLine(currentPlayer + howMany);
    string currentPlayer = Console.ReadLine();
    currentPlayerI = Convert.ToInt32(currentPlayer);
}

//check amount matches drawn (use clamp)
void checkDraw
{
    if (currentPlayerI > 3)
    {
        Console.WriteLine("Please draw between 1 - 3 matches only");
        drawMatches;
    }
}*/

/*Game Mechanics:
 players draw 1-3 matches. Cant draw more then remainingMatches. when there is 1 match left, 
 the player wins.
 Game - 
 player1 draws (is it more then 3, yes draw again) subtract player1draw from remaining matches.
 Is there 1 match left (yes player1 wins) player2 draws
 player2 draws (is it more then 3, yes draw again) subtract player2draw from remaining matches.
 Is there 1 match left (yes player2 wins) player1 draws*/

//Players enter name
Console.WriteLine("Player 1, please enter your name");
string player1 = Console.ReadLine();
Console.WriteLine("Player 2, please enter your name");
string player2 = Console.ReadLine();

//Game start
Console.WriteLine("Lets Play !");


{
    for (int i = 0; i < startMatches; i++)
    {
        Console.Write("|");
    }

    Console.WriteLine(remainingMatches); //Fix brackets

//Drawing mechanic
    while (remainingMatches != 1)
    {



//player1 Draw
        Console.WriteLine(player1 + howMany);
        string drawPlayer1 = Console.ReadLine();
        drawPlayer1I = Convert.ToInt32(drawPlayer1);
        drawPlayer1I = (int)Math.Clamp((double)drawPlayer1I, 0, 3);
        remainingMatches = startMatches - drawPlayer1I;

        for (int i = 0; i < startMatches; i++)
        {
            Console.Write("|");
        }

        Console.WriteLine(remainingMatches); //Fix brackets

        startMatches = remainingMatches;

//player2 Draw
        Console.WriteLine(player2 + howMany);
        string drawPlayer2 = Console.ReadLine();
        drawPlayer2I = Convert.ToInt32(drawPlayer2);
        drawPlayer2I = (int)Math.Clamp((double)drawPlayer2I, 0, 3);
        remainingMatches = startMatches - drawPlayer2I;

        for (int i = 0; i < startMatches; i++)
        {
            Console.Write("|");
        }

        Console.WriteLine(remainingMatches); //Fix brackets
        
        startMatches = remainingMatches;
    }
//Console.WriteLine("You win!");
//check if remaining matches = 1, if so player wins


//if matches > 1 then return to player1 draw matches
}
Console.WriteLine("You win!");