Console.WriteLine("What's your first name");
string firstName = Console.ReadLine();
Console.WriteLine("What's your second name");
string secondName = Console.ReadLine();
Console.WriteLine("What's your age");
string age = Console.ReadLine();
string message = $"Hello {firstName} {secondName}, you are {age} years old!";
Console.WriteLine(message);