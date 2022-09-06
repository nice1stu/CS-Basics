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

//Generate 5 random attacks to determine Crit success
Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
string crit = Console.ReadLine();
double critInt = Convert.ToDouble(crit);

double crit1 = random.NextDouble()*critInt+(1-critInt);
//Console.WriteLine(crit1);
string attack1 = crit1 < critInt ? "Critcal!" : "No Critical";
Console.WriteLine(attack1);
double crit2 = random.NextDouble()*critInt+(1-critInt);
//Console.WriteLine(crit2);
string attack2 = crit2 < critInt ? "Critcal!" : "No Critical";
Console.WriteLine(attack2);
double crit3 = random.NextDouble()*critInt+(1-critInt);
//Console.WriteLine(crit3);
string attack3 = crit3 < critInt ? "Critcal!" : "No Critical";
Console.WriteLine(attack3);
double crit4 = random.NextDouble()*critInt+(1-critInt);
//Console.WriteLine(crit4);
string attack4 = crit4 < critInt ? "Critcal!" : "No Critical";
Console.WriteLine(attack4);
double crit5 = random.NextDouble()*critInt+(1-critInt);
//Console.WriteLine(crit5);
string attack5 = crit5 < critInt ? "Critcal!" : "No Critical";
Console.WriteLine(attack5);
/*string attack5;
if (crit5 < critInt) {
    attack5 = "Critical!";
}
else {
    attack5 = "No Critical";
}
Console.WriteLine(attack5);*/