//Start game
Console.WriteLine("Welcome to Nim!");
Console.WriteLine("How to play");
Console.WriteLine("2 Players");
Console.WriteLine("Players take turns to draw matches");
Console.WriteLine("Each player may draw 1,2 or 3 matches (not more or less)");
Console.WriteLine("The Player who has to take last match loses");
Console.WriteLine("Good Luck!");

//Set up game
double startMatches = 24;
double remainingMatches = 24;
int drawPlayer2I;
int drawPlayer1I;
string howMany = " How many matches do you want to draw?";
string winnerIs = "Bob";

remainingMatches = startMatches;

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
    string collate = $" ({remainingMatches})";
    Console.WriteLine(collate);

//Drawing mechanic
    while (remainingMatches != 1)
    {
        if (remainingMatches != 1)
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
            string interp = $" ({remainingMatches})";
            Console.WriteLine(interp);

            if (remainingMatches > 1)
            {
                startMatches = remainingMatches;
                //    double ceil = Math.Ceiling(12.1); apply to eliminate 0
            }
            else
            {
                Console.Write(player1);
                Console.WriteLine(" Wins !");
            }
        }
        
        if (remainingMatches != 1)
        {//player2 Draw

            Console.WriteLine(player2 + howMany);
            string drawPlayer2 = Console.ReadLine();
            drawPlayer2I = Convert.ToInt32(drawPlayer2);
            drawPlayer2I = (int)Math.Clamp((double)drawPlayer2I, 0, 3);
            remainingMatches = startMatches - drawPlayer2I;

            for (int i = 0; i < startMatches; i++)
            {
                Console.Write("|");
            }
            string interp = $" ({remainingMatches})";
            Console.WriteLine(interp);
            
            if (remainingMatches > 1)
            {
                startMatches = remainingMatches;
                //    double ceil = Math.Ceiling(12.1); apply to eliminate 0
                
            }
            else
            {
                Console.Write(player2);
                Console.WriteLine(" Wins !");
            }
        }
}
}