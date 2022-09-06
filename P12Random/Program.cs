Console.WriteLine("Please pass me a Seed");
string seed = Console.ReadLine();
int seedInt = Convert.ToInt32(seed);

// Generate 3 Random int
Console.WriteLine("Three integers between 0 and 5");
Random random = new Random(seedInt);
int num1 = random.Next(0, 5);
Console.WriteLine(num1);
int num2 = random.Next(0, 5);
Console.WriteLine(num2);
int num3 = random.Next(0, 5);
Console.WriteLine(num3);
Console.WriteLine(seedInt);
//Generate 3 random float 0-0.5
double num4 = random.NextDouble()*0.5;
Console.WriteLine(num4);
double num5 = random.NextDouble()*0.5;
Console.WriteLine(num5);
double num6 = random.NextDouble()*0.5;
Console.WriteLine(num6);
//Generate 3 random float 0.2-0.7
Console.WriteLine("Three numbers between 0.2 and 0.7");
double num7 = random.NextDouble()*(0.7-0.2)+0.2;
Console.WriteLine(num7);
double num8 = random.NextDouble()*(0.7-0.2)+0.2;
Console.WriteLine(num8);
double num9 = random.NextDouble()*(0.7-0.2)+0.2;
Console.WriteLine(num9);
