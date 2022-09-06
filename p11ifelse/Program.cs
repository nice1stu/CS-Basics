using System.ComponentModel.Design;
using System.Net;

//string largerNumber;
//int biggerNumber;
//string parity;

Console.WriteLine("What is your age?");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);

if (ageInt < 13) {
    Console.WriteLine("You are a child");
}
else if (ageInt < 19) {
    Console.WriteLine("You are a Teenager");
}
else {
    Console.WriteLine("You are a grown-up");
}

Console.WriteLine("Give me another number");
string secondNumber = Console.ReadLine();
int secondNumberI = Convert.ToInt32(secondNumber);

/* Original code
 if (ageInt > secondNumberI)
{
    largerNumber = "Age";
    Console.WriteLine("Your age is larger");
}
else if (ageInt < secondNumberI)
{
    largerNumber = "Number";
    Console.WriteLine("Your age is smaller");
}
else
{
    largerNumber = "Age is same Number";
    Console.WriteLine("The Number entered is same as your age");
}*/

string greeting = ageInt > secondNumberI ? "Your age is larger" : "Your age is smaller";
Console.WriteLine(greeting);

// Console.WriteLine(largerNumber); check if correct
/*if (ageInt > secondNumberI)
{
    biggerNumber = ageInt;
}

if (ageInt > secondNumberI)
{
    biggerNumber = secondNumberI;
}

    if (biggerNumber % 2 == 0)
{
    parity = "Even";
}
else
{
    parity = "Odd";
}
string message = $"{biggerNumber} is {parity}";*/