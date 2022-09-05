

Console.WriteLine("Please type in a number with decimal (.), then press [ENTER]");
string answer = Console.ReadLine(); //Get number, store in answer
string originalAnswer = answer;

Console.WriteLine(originalAnswer); // Checking originalAnswer = answer

// Convert to Double Number
double doubled = Convert.ToDouble(answer);
Console.WriteLine(doubled);

Console.WriteLine(answer); // Checking value of answer

//Convert from Double to int Number
int intNumber = Convert.ToInt32(doubled);
Console.WriteLine(intNumber);

//Convert original answer to int
int intNumber2 = Convert.ToInt32(originalAnswer);
Console.WriteLine(intNumber2);
