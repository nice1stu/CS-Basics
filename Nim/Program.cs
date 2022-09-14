//Nim+ with AI Player
//Start game
Console.WriteLine("-- Welcome to Nim! --");
Console.WriteLine(" ");
Console.WriteLine("How to play");
Console.WriteLine(" ");
Console.WriteLine("2 Players");
Console.WriteLine("Players take turns to draw matches");
Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less)");
Console.WriteLine("The Player who has to take last match loses");
Console.WriteLine(" ");
Console.WriteLine("Good Luck!");
Console.WriteLine(" ");

//Set up game
double startMatches = 24;
double remainingMatches = startMatches;
string howMany = " How many matches do you want to draw?";

//int numPlayers;
string player1;
string player2;
string currentPlayer;

//Setup Game

//Number of players
Console.WriteLine("Please enter the number of player 1 or 2");
int numPlayers = Convert.ToInt32(Console.ReadLine());
numPlayers = (int)Math.Clamp((double)numPlayers, 1, 2);
if (numPlayers == 2)
{
    //Players enter name
    Console.WriteLine("Player 1, please enter your name");
    player1 = Console.ReadLine();
    Console.WriteLine("Player 2, please enter your name");
    player2 = Console.ReadLine();
}
else
{
    Console.WriteLine("Player 1, please enter your name");
    player1 = Console.ReadLine();
    Console.WriteLine("Player 2 is HAL2000");
    player2 = "HAL2000";
}

//Game start
Console.WriteLine(" ");
Console.WriteLine("Lets Play !");

for (int i = 0; i < startMatches; i++)
{
    Console.Write("|");
}
string displayBrackets = $" ({remainingMatches})";
Console.WriteLine(displayBrackets);

//number of players
if (numPlayers == 2)
{
    while (remainingMatches > 1)
    {
        //player1 Draw
        currentPlayer = player1;
        DrawMechanic();
        //player2 Draw
        if (remainingMatches > 1)
        {
            currentPlayer = player2;
            DrawMechanic();
        }
        else
        {
            EndGame();
        }
    }
}
else //single player with AI
{
    while (remainingMatches > 1)
    {
        //player1 Draw
        currentPlayer = player1;
        DrawMechanic();
        //player2AI Draw
        DrawMechanicAi();
    }
}

//Draw mechanic
    void DrawMechanic()
    {
        //currentPlayer Draw
        int currentPlayerI = 0;
        Console.WriteLine(currentPlayer + howMany);
        while (currentPlayerI != 1 && currentPlayerI != 2 && currentPlayerI != 3)
        {
        try
        { 
            currentPlayerI = Convert.ToInt32(Console.ReadLine()); 
            currentPlayerI = (int)Math.Clamp((double)currentPlayerI, 0, 3);
        }
        catch (Exception)
        {
            Console.WriteLine("Please enter a number 1,2 or 3");
        }
    }

    remainingMatches = startMatches - currentPlayerI;
    remainingMatches = Math.Max(1, remainingMatches);
    startMatches = remainingMatches;

    if (remainingMatches > 1)
    {
        //Drawing matches
        for (int i = 0; i < startMatches; i++)
        {
            Console.Write("|");
        }

        string putInBrackets = $" ({remainingMatches})";
        Console.WriteLine(putInBrackets);
    }
    else
    {
        Console.Write(currentPlayer);
        Console.WriteLine(" Wins !");
        EndGame();
    }
}

//Draw mechanic AI
    void DrawMechanicAi()
    {
            // AI Player2 Draw
            double drawPlayer2I = (remainingMatches % 4) - 1;
            drawPlayer2I = (int)Math.Clamp(drawPlayer2I, 1, 3);
            Console.Write("HAL2000 draws ");
            Console.WriteLine(drawPlayer2I);

            remainingMatches = startMatches - drawPlayer2I;
            remainingMatches = Math.Max(1, remainingMatches);
            startMatches = remainingMatches;

            for (int i = 0; i < startMatches; i++)
            {
                Console.Write("|");
            }

            string putInBrackets2 = $" ({remainingMatches})";
            Console.WriteLine(putInBrackets2);

            if (remainingMatches > 1)
            {
                startMatches = remainingMatches;
                Console.WriteLine(startMatches);
            }
            else
            {
                Console.Write(player2);
                Console.WriteLine(" Wins !");
                EndGame();
            }
    }
//End Game
void EndGame()
{
    //Console.Clear();
    Console.WriteLine("Thanks for Playing");
}