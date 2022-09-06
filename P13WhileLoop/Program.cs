int i = 0;

while (i < 3)
{
    Console.WriteLine(i); // print i to the console
    i++; // increase i by 1
}

bool userHasAgreed = false;
// Repeat the loop while the user has not agreed, yet.
while(userHasAgreed == false)
{
    // Ask the uer to agree.
    Console.WriteLine("Please agree by writing 'yes'");
    // If the user types in "yes"...
    if(Console.ReadLine() == "yes")
    {
        // Then we take it as an agreement.
        userHasAgreed = true;
    }
}

int j = 100;

do {
    // First, print the current number
    Console.WriteLine(i);
    j++;
}
while (j < 3); // Then, check, if the current Number is still smaller than 3. If not, interrupt.

bool userHasAgreed;
do
{
    // Ask the uer to agree.
    Console.WriteLine("Please agree by writing 'yes'");
    // If the user types in "yes"...
    if(Console.ReadLine() == "yes")
    {
        // Then we take it as an agreement.
        userHasAgreed = true;
    } else {
        userHasAgreed = false;  
    }
}
while(userHasAgreed == false); // Repeat the loop while the user has not agreed, yet.