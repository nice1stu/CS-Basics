using System.ComponentModel.Design;

Console.WriteLine("What is your age?");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);
/*
bool isChild = ageInt < 13;
Console.WriteLine(isChild);

bool isTeenager = !isChild && ageInt < 19;
Console.WriteLine(isTeenager);

bool isGrownup = ageInt > 18;
Console.WriteLine(isGrownup);*/
      
if (ageInt < 13) {
    Console.WriteLine("You are a child");
}
else if (ageInt < 19) {
    Console.WriteLine("You are a Teenager");
}
else {
    Console.WriteLine("You are a grown-up");
}        