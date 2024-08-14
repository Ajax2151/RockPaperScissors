string userChoice = " ";
int computerToss = 0;
int userToss = 0;

Console.WriteLine("Please enter your choice: Rock, Paper, or Scissors.");
userChoice = Console.ReadLine().ToLower().Trim();

if ((userChoice != "rock") && (userChoice != "paper") && (userChoice != "scissors"))
{
    Console.WriteLine("Sorry, that's not a valid option.");
}
else
{
    switch (userChoice)
    {
        case "rock":
            userToss = 0;
            break;
        case "paper":
            userToss = 1;
            break;
        case "scissors":
            userToss = 2;
            break;
    }

    Random toss = new Random();
    computerToss = toss.Next(3);

    switch (userToss)
    {
        case 0:
            Console.WriteLine("You chose 'Rock'.");
            break;
        case 1:
            Console.WriteLine("You chose 'Paper'.");
            break;
        case 2:
            Console.WriteLine("You chose 'Scissors'.");
            break;
    }

    switch (computerToss)
    {
        case 0:
            Console.WriteLine("The computer chose 'Rock'.");
            break;
        case 1:
            Console.WriteLine("The computer chose 'Paper'.");
            break;
        case 2:
            Console.WriteLine("The computer chose 'Scissors'.");
            break;
    }

    if (userToss == computerToss)
        Console.WriteLine("It's a draw!");
    else if ((userToss == 0) && (computerToss == 2))
        Console.WriteLine("Congratulations - you win!");
    else if ((computerToss == 0) && (userToss == 2))
        Console.WriteLine("Sorry, you lose.");
    else if (userToss > computerToss)
        Console.WriteLine("Congratulations - you win!");
    else
        Console.WriteLine("Sorry, you lose.");
}