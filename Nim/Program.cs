﻿//Nim+ with AI Player

double startMatches;
double remainingMatches;

string? player1;
string? player2;
string? currentPlayer;

double drawPlayer2I;

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

StartGame();

void StartGame()
{
//Set up new game
startMatches = 24;
remainingMatches = startMatches;
string howMany = " How many matches do you want to draw?";

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
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        player1 = Console.ReadLine();
        Console.WriteLine("Choose your difficulty level:");
        Console.WriteLine("[1] for Easy");
        Console.WriteLine("[2] for Hard");
        int difficulty = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (difficulty == 1)
        {
            player2 = "Wall-E";
            Console.WriteLine($"Player 2 is {player2}");
        }
        else
        {
            player2 = "HAL9000";
            Console.WriteLine($"Player 2 is {player2}");
        }
    }

//Play start
    Console.WriteLine(" ");
    Console.WriteLine("Lets Play !");
    Console.WriteLine(" ");

    for (int i = 0; i < startMatches; i++)
    {
        Console.Write("|");
    }

    string displayBrackets = $" ({remainingMatches})";
    Console.WriteLine(displayBrackets);

    //2 players
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
                break;
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
            if (player2 == "Wall-E")
            {

                if (remainingMatches > 0)
                {
                    DrawMechanicWalLe();
                }
                else
                {
                    break;
                }
            }
            else
            {
                DrawMechanicAi();
            }
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
                currentPlayerI = (int)Math.Clamp((double)currentPlayerI, 1, 3);
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
            DisplayMatches();
        }
        else
        {
            Console.WriteLine("There is 1 match left.");
            Console.WriteLine($"{currentPlayer} Wins !");
            PlayAgain();
        }
    }

    //Draw mechanic HAL9000 (%4 plays to win)
    void DrawMechanicAi()
    {
        // AI HAL9000 Draw
        drawPlayer2I = (remainingMatches % 4) - 1;
        drawPlayer2I = (int)Math.Clamp(drawPlayer2I, 1, 3);
        Console.Write("HAL2000 draws ");
        Console.WriteLine(drawPlayer2I);
        
        CountMatches();
        DisplayMatches();
        CheckWin();
    }

    //Draw mechanic WALL-E (draws random amount)
    void DrawMechanicWalLe()
    {
        // AI WALL-E Draw1
        Random random = new Random();
        drawPlayer2I = random.Next(1, 4);
        Console.Write("WALL-E draws ");
        Console.WriteLine(drawPlayer2I);
        
        CountMatches();
        DisplayMatches();
        CheckWin();
    }
}

//Calculate remaining matches
void CountMatches()
{
    remainingMatches = startMatches - drawPlayer2I;
    remainingMatches = Math.Max(1, remainingMatches);
    startMatches = remainingMatches;
}

//Display matches onscreen
void DisplayMatches()
{
    for (int i = 0; i < startMatches; i++)
    {
        Console.Write("|");
    }

    string putInBrackets2 = $" ({remainingMatches})";
    Console.WriteLine(putInBrackets2);
}

//Check for win
void CheckWin()
{
    if (remainingMatches > 1)
    {
        startMatches = remainingMatches;
    }
    else
    {
        Console.WriteLine($"You must draw last match.");
        Console.WriteLine($"{player2} Wins !");
        PlayAgain();
    }
}

//Ask Play Again
void PlayAgain()
{
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    int playAgain = Convert.ToInt32(Console.ReadLine());
    if (playAgain == 1)
    {
        Console.Clear();
        StartGame();
    }
    else
    {
        Console.Clear();
        EndGame();
    }
}

//End Game
void EndGame()
{
    Console.WriteLine("Thanks for Playing");
    Environment.Exit(0);
}