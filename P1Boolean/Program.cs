Console.WriteLine("What is your age?");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);

// isChild = >0 && <=12;
// isTeenager = >=13 && <=19;
// isGrownup = >19;

bool isChild = ageInt < 13;
Console.WriteLine(isChild);

bool isTeenager = !isChild && ageInt < 19;
Console.WriteLine(isTeenager);

bool isGrownup = ageInt > 18;
Console.WriteLine(isGrownup);

Console.Write("You are a child:");
Console.WriteLine(isChild);

Console.Write("You are a teenager:");
Console.WriteLine(isTeenager);

Console.Write("You are a grown-up:");
Console.WriteLine(isGrownup);
