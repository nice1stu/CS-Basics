//Nim+ with AI Player
//Start game
Console.WriteLine("-- Welcome to Nim! --");
Console.WriteLine("How to play");
Console.WriteLine("2 Players");
Console.WriteLine("Players take turns to draw matches");
Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less)");
Console.WriteLine("The Player who has to take last match loses");
Console.WriteLine("Good Luck!");
Console.WriteLine(" ");

//Set up game
double startMatches = 24;
double remainingMatches = startMatches;
string howMany = " How many matches do you want to draw?";
//int numPlayers;
string player1;
string player2;


//Start Game
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

{
    for (int i = 0; i < startMatches; i++)
    {
        Console.Write("|");
    }

    string displayBrackets = $" ({remainingMatches})";
    Console.WriteLine(displayBrackets);

//Drawing mechanic
    if (numPlayers == 2)
    {
        while (remainingMatches > 1)
        {
            if (remainingMatches > 1)
            {
                //player1 Draw
                int drawPlayer1I = 0;
                Console.WriteLine(player1 + howMany);
                //drawPlayer1I = 0;
                while (drawPlayer1I != 1 && drawPlayer1I != 2 && drawPlayer1I != 3)
                {
                    try
                    {
                        drawPlayer1I = Convert.ToInt32(Console.ReadLine());
                        drawPlayer1I = (int)Math.Clamp((double)drawPlayer1I, 0, 3);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number 1,2 or 3");
                    }
                }

                remainingMatches = startMatches - drawPlayer1I;
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
                    Console.Write(player1);
                    Console.WriteLine(" Wins !");
                }

            }

            if (remainingMatches > 1)
            {
                // Player2 Draw
                int drawPlayer2I = 0;
                Console.WriteLine(player2 + howMany);
                //drawPlayer2I = 0;
                while (drawPlayer2I != 1 && drawPlayer2I != 2 && drawPlayer2I != 3)
                {
                    try
                    {
                        //string drawPlayer2 = Console.ReadLine();
                        drawPlayer2I = Convert.ToInt32(Console.ReadLine());
                        drawPlayer2I = (int)Math.Clamp((double)drawPlayer2I, 0, 3);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number 1,2 or 3");
                    }
                }

                remainingMatches = startMatches - drawPlayer2I;
                remainingMatches = Math.Max(1, remainingMatches);
                startMatches = remainingMatches;

                for (int i = 0; i < startMatches; i++)
                {
                    Console.Write("|");
                }

                string putInBrackets = $" ({remainingMatches})";
                Console.WriteLine(putInBrackets); //

                if (remainingMatches > 1)
                {
                    startMatches = remainingMatches;
                    Console.WriteLine(startMatches);
                }
                else
                {
                    Console.Write(player2);
                    Console.WriteLine(" Wins !");
                }
            }
        }
    }
    else // 1 Player with player 2 AI
    {
        while (remainingMatches > 1)
        {
            if (remainingMatches > 1)
            {
                //player1 Draw
                int drawPlayer1I = 0;
                Console.WriteLine(player1 + howMany);
                //drawPlayer1I = 0;
                while (drawPlayer1I != 1 && drawPlayer1I != 2 && drawPlayer1I != 3)
                {
                    try
                    {
                        drawPlayer1I = Convert.ToInt32(Console.ReadLine());
                        drawPlayer1I = (int)Math.Clamp((double)drawPlayer1I, 0, 3);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number 1,2 or 3");
                    }
                }

                remainingMatches = startMatches - drawPlayer1I;
                remainingMatches = Math.Max(1, remainingMatches);
                startMatches = remainingMatches;

                if (remainingMatches > 1)
                {
                    for (int i = 0; i < startMatches; i++)
                    {
                        Console.Write("|");
                    }

                    string putInBrackets2 = $" ({remainingMatches})";
                    Console.WriteLine(putInBrackets2);
                }
                else
                {
                    Console.Write(player1);
                    Console.WriteLine(" Wins !");
                }

            }
            if (remainingMatches > 1)
            {
                // AI Player2 Draw
                double drawPlayer2I = 0;
                if ( (remainingMatches > 21))
                {
                    drawPlayer2I = remainingMatches - 21;
                }
                else if (remainingMatches > 17)
                {
                    drawPlayer2I = remainingMatches - 17;
                }
                else if (remainingMatches > 13)
                {
                    drawPlayer2I = remainingMatches - 13;
                }
                else if (remainingMatches > 9)
                {
                    drawPlayer2I = remainingMatches - 9;
                }
                else if (remainingMatches > 5)
                {
                    drawPlayer2I = remainingMatches - 5;
                }
                else if (remainingMatches == 5)
                {
                    drawPlayer2I = 3;
                }
                else if (remainingMatches < 5)
                {
                    drawPlayer2I = remainingMatches - 1;
                }
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
                Console.WriteLine(putInBrackets2); //

                if (remainingMatches > 1)
                {
                    startMatches = remainingMatches;
                    Console.WriteLine(startMatches);
                }
                else
                {
                    Console.Write(player2);
                    Console.WriteLine(" Wins !");
                }
            }
        }
    }
}


