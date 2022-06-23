string runTime = "Y";

//Greet and take response
Console.WriteLine("Hello and welcome to the number analyzer. What is your name?");
string userName = Console.ReadLine();

do
{



    Console.WriteLine("Okay, " + userName + ". Please enter a number between 1 and 100.");
    int response = 0;

    //validate that the number is positive and between specified range. If not, prompt again
    while (!int.TryParse(Console.ReadLine(), out response) || (response < 1 || response > 100))
    {
        Console.WriteLine("Please enter a positive number between 1 and 100.");
        
    }
    if( response > 100 || response < 0)
    {
        continue;
    }


    //take different actions and give output

    if (response % 2 == 1 && response < 60)
    {
        Console.WriteLine(response + " is odd and less than 60.");
    }
    else if(response >= 2 && response <= 24)
    {
        Console.WriteLine("Even and less than 25.");
    }
    else if(response >= 26 && response <= 60)
    {
        Console.WriteLine("Even and between 26 and 60 inclusive.");
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
    Console.WriteLine(userName + ", Would you like to analyze another number? \nPlease type 'Y' to continue and hit any other key to end the program.");
    runTime = Console.ReadLine();
    

}
while (runTime.ToUpper() == "Y");