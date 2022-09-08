// TicTacToe

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("-- Welcome to Tic Tac Toe --");

int numPlayers;
string player1;
string player2;
// assign player1 = x, assign player2 = o
int x = 10;
int o = 0;
//What value is stored
int k1I = 5;
int k2I = 5;
int k3I = 5;
int k4I = 5;
int k5I = 5;
int k6I = 5;
int k7I = 5;
int k8I = 5;
int k9I = 5;
int k1k3RowI = 15;
int k4k6RowI = 15;
int k7k9RowI = 15;
int k1k7ColumnI = 15;
int k2k8ColumnI = 15;
int k3k9ColumnI = 15;
int k1k9DiagonalI = 15;
int k3k7DiagonalI = 15;
// What value is shown
string k1 = "1";
string k2 = "2";
string k3 = "3";
string k4 = "4";
string k5 = "5";
string k6 = "6";
string k7 = "7";
string k8 = "8";
string k9 = "9";



//Number of players
Console.WriteLine("Please enter the number of player 1 or 2");
numPlayers = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine(" ");

//Draw Board
Console.WriteLine(" 7 | 8 | 9 ");
Console.WriteLine(" - | - | - ");
Console.WriteLine(" 4 | 5 | 6 ");
Console.WriteLine(" - | - | - ");
Console.WriteLine(" 1 | 2 | 3 ");

// Player Turns
// player1 choose
Console.Write(player1);
Console.WriteLine(" choose the Number of the square you want to place your x");
int choicePlayer1 = Convert.ToInt32(Console.ReadLine());
//match choicePlayer1 to KX. replace kX = x
//kXi = 10
//check sum of rows, columns diagonals, if sum = 30 player1 wins

// player2 choose
Console.Write(player2);
Console.WriteLine(" choose the Number of the square you want to place your o");
int choicePlayer2 = Convert.ToInt32(Console.ReadLine());
//match choicePlayer1 to KX. replace kX = o
//kXi = 0
//check sum of rows, columns diagonals, if sum = 0 player2 wins
