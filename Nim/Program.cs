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
double remainingMatches;
int drawPlayer2I;
int drawPlayer1I;
string howMany = " How many matches do you want to draw?";

remainingMatches = startMatches;

//Players enter name
Console.WriteLine("Player 1, please enter your name");
string player1 = Console.ReadLine();
Console.WriteLine("Player 2, please enter your name");
string player2 = Console.ReadLine();

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
    while (remainingMatches > 1)
    {
        if (remainingMatches > 1)
        {
            //player1 Draw
            Console.WriteLine(player1 + howMany);
            drawPlayer1I = 0;
            while (drawPlayer1I != 1 &&  drawPlayer1I != 2 && drawPlayer1I != 3)
            {
                try
                {
                    //string drawPlayer1 = Console.ReadLine();
                    drawPlayer1I = Convert.ToInt32(Console.ReadLine());
                    drawPlayer1I = (int)Math.Clamp((double)drawPlayer1I, 0, 3);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number 1,2 or 3");
                }
            }
            remainingMatches = startMatches - drawPlayer1I; 
            remainingMatches = Math.Max(1, remainingMatches);

            if (remainingMatches > 1) //does not print win startement
            {
                for (int i = 0; i < startMatches; i++)
                {
                    Console.Write("|");
                }

                string putInBrackets = $" ({remainingMatches})";
                Console.WriteLine(putInBrackets);

                //if (remainingMatches > 1)
                //{
                //    startMatches = remainingMatches;
            } //}
            else
            {
                    Console.Write(player1);
                    Console.WriteLine(" Wins !");
            }
            
        }
        
        if (remainingMatches > 1)
        {//player2 Draw
            Console.WriteLine(player2 + howMany);
            drawPlayer2I = 0;
            while (drawPlayer2I != 1 &&  drawPlayer2I != 2 && drawPlayer2I != 3)
            {
                try
                {
                    //string drawPlayer2 = Console.ReadLine();
                    drawPlayer2I = Convert.ToInt32(Console.ReadLine());
                    drawPlayer2I = (int)Math.Clamp((double)drawPlayer2I, 0, 3);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number 1,2 or 3");
                }
            }
            remainingMatches = startMatches - drawPlayer2I;
            remainingMatches = Math.Max(1, remainingMatches);

            for (int i = 0; i < startMatches; i++)
            {
                Console.Write("|");
            }
            string putInBrackets = $" ({remainingMatches})";
            Console.WriteLine(putInBrackets);//
            
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