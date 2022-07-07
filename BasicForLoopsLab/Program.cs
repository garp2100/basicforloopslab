//Prompt the user to enter a number.  Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
bool runAgain = true;
while (runAgain)
{
    int j;
    int sum = 0;
    Console.WriteLine("Please enter a number: ");
    int input = int.Parse(Console.ReadLine());
    for (j = 1; j <= input; j++)
    {
        sum = sum + j;
        
    }
    Console.WriteLine(sum);
    bool restart = true;
    while (restart)
    {
        Console.WriteLine("Would you like to continue? (y/n)?");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            break;
        else Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}
