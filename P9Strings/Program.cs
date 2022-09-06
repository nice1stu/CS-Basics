Console.WriteLine("What's your first name");
string firstName = Console.ReadLine();
Console.WriteLine("What's your second name");
string secondName = Console.ReadLine();
Console.WriteLine("What's your age");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);
string message = $"Hello {firstName} {secondName}, you are {ageInt} years old!";
Console.WriteLine(message);