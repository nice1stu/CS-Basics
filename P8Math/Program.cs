// ask user for first number
Console.WriteLine("Give me your first number.");
string first = Console.ReadLine();
double firstDoubled = Convert.ToDouble(first);
// Console.WriteLine(firstDoubled); // check value of firstDoubled
Console.WriteLine("Give me your second number.");
string second = Console.ReadLine();
double secondDoubled = Convert.ToDouble(second);
// Console.WriteLine(secondDoubled); // check value of sceondDoubled

double max = Math.Max(firstDoubled, secondDoubled);
Console.WriteLine(max);

double min = Math.Min(firstDoubled, secondDoubled);
Console.WriteLine(min);

double sqrt = Math.Sqrt(firstDoubled);
Console.WriteLine(sqrt);

double abs = Math.Abs(firstDoubled);
Console.WriteLine(abs);

double round = Math.Round(firstDoubled);
Console.WriteLine(round);

double floor = Math.Floor(firstDoubled);
Console.WriteLine(floor);

double ceiling = Math.Ceiling(firstDoubled);
Console.WriteLine(ceiling);

double clamp = Math.Clamp(firstDoubled, 0, secondDoubled);
Console.WriteLine(clamp);

double pow = Math.Pow(firstDoubled, secondDoubled);
Console.WriteLine(pow);