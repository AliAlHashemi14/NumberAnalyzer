string runTime = "";
do
{


    //Greet and take response
    Console.WriteLine("Welcome to the number analyzer. Please enter a number between 1 and 100.");
    int response = int.Parse(Console.ReadLine());

    //take different actions and output

    if (response % 2 == 1 && response < 60)
    {
        Console.WriteLine(response + " is odd and less than 60.");
    }
    else if(response % 2 == 0 && response >= 2 && response <= 24)
    {
        Console.WriteLine(response + " is even and less than 25.");
    }
    else if(response % 2 == 0 && response >= 26 && response <= 60)
    {
        Console.WriteLine(response + " is even and between 26 and 60 inclusive.");
    }
    else if(response % 2 == 0 && response > 60)
    {
        Console.WriteLine(response + " is even and greater than 60.");
    }
    else if(response % 2 == 1 && response > 60)
    {
        Console.WriteLine(response + " is odd and greater than 60.");
    }


    //prompt to end the program
    Console.WriteLine("Would you like to analyze another number? \nPlease type 'Y' to continue and hit any other key to end the program.");
    runTime = Console.ReadLine();
    

}
while (runTime.ToUpper() == "Y");