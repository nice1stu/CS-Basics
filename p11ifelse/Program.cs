﻿using System.ComponentModel.Design;

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
float secondNumberF = Convert.ToInt32(secondNumber);

if (ageInt > secondNumberF)
{
    Console.WriteLine("Your age is larger");
}
else
{
    Console.WriteLine("The Number entered is larger");
}