

Console.WriteLine("Please type in a number with decimal (.), then press [ENTER]");
string answer = Console.ReadLine(); //Get number, store in answer
string originalAnswer = answer;

double answerDoubled = Convert.ToDouble(answer);
Console.WriteLine(answerDoubled);

int answerInt = Convert.ToInt32(answerDoubled);
Console.WriteLine(answerInt);

int answer2Int = Convert.ToInt32(answer);
Console.WriteLine(answer2Int);