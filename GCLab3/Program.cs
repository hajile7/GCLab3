//begin our infinite program loop
bool runProgram = true;
while (runProgram)
{

    //welcome
    Console.WriteLine("Welcome to the exponent analyzer!");

    //get user input & ensure they made an appropriate choice
    Console.WriteLine("Please enter an integer:");
    int choice = int.Parse(Console.ReadLine());
    while (choice <= 0 || choice > 1290)
    {
        Console.WriteLine("That is an invalid choice. Please choose an integer between 1 and 1290");
        choice = int.Parse(Console.ReadLine());
    }

    //displaying the table headers
    Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
    Console.WriteLine("=======" + "\t" + "=======" + "\t" + "=======");

    //creating the table of numbers
    for (int i = 1; i <= choice; i++)
    {
        Console.WriteLine(i + "\t" + squared(i) + "\t" + cubed(i));
    }

    //methods
    static int squared(int x)
    {
        return x * x;
    }

    static int cubed(int x)
    {
        return x * x * x;
    }
    //see if user would like to contiue with the program or not
    while (true)
    {
        Console.WriteLine("Would you like to continue using this program? y/n");
        string progChoice = Console.ReadLine().ToLower().Trim();
        if (progChoice == "y")
        {
            runProgram = true;
            break;
        }
        else if (progChoice == "n")
        {
            Console.WriteLine("Thank you for using the exponent analyzer. Goodbye!");
            runProgram = false;
            break;
        }
    }

}