string userChoice = "";
int userToss = 0;
int playerScore = 0;
int computerScore = 0;

string? readResult;
// bool playGame = true;

do
{
    Console.WriteLine("Please enter your choice: Rock, Paper, or Scissors.");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        userChoice = readResult.ToLower().Trim();
    }

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

        int computerToss = 0;
        Random toss = new Random();
        computerToss = toss.Next(3);

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
        {
            Console.WriteLine("It's a draw!");
        }
        else if ((userToss == 0) && (computerToss == 2))
        {
            playerScore++;
            Console.WriteLine("Congratulations - you win!");
        }
        else if ((computerToss == 0) && (userToss == 2))
        {
            computerScore++;
            Console.WriteLine("Sorry, you lose.");
        }
        else if (userToss > computerToss)
        {
            playerScore++;
            Console.WriteLine("Congratulations - you win!");
        }
        else
        {
            computerScore++;
            Console.WriteLine("Sorry, you lose.");
        }
        
        Console.WriteLine($"You've won {playerScore} rounds. The computer has won {computerScore} rounds.");
    }
} while (playerScore < 3 && computerScore < 3);

Console.WriteLine($"The final score is: \n\tPlayer: {playerScore}\n\tComputer: {computerScore}");
Console.WriteLine("Thank you for playing!");

Console.WriteLine("Press Enter to exit.");
Console.ReadLine();