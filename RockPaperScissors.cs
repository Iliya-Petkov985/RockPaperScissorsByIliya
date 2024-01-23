
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

string command = "";
while (command != "no")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
    string playerMove = Console.ReadLine();

        if (playerMove == "r" || playerMove == "rock")
        {
            playerMove = Rock;
        }
        else if (playerMove == "p" || playerMove == "paper")
        {
            playerMove = Paper;
        }
        else if (playerMove == "s" || playerMove == "scissors")
        {
            playerMove = Scissors;
        }
        else
        {
            Console.WriteLine("Invalid Input. Try Again ...");
             continue;
        }

    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);

    string computerMove = "";

    switch (computerRandomNumber)
    {
        case 1:
            computerMove = Rock;
            break;
        case 2:
            computerMove = Paper;
            break;
        case 3:
            computerMove = Scissors;
            break;
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"The computer chose {computerMove}.");

    if ((playerMove == Rock && computerMove == Scissors) ||
        (playerMove == Paper && computerMove == Rock) ||
        (playerMove == Scissors && computerMove == Paper))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You Win.");
    }
    else if ((playerMove == Rock && computerMove == Paper) ||
        (playerMove == Paper && computerMove == Scissors) ||
        (playerMove == Scissors && computerMove == Rock))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This game was a draw.");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type [yes] to Play Again or [no] to quit: ");
     command = Console.ReadLine(); 

   while(command != "yes")
   {
       if(command == "no")
       {
            break;
       }
        Console.Write("Type [yes] to Play Again or [no] to quit: ");
        command = Console.ReadLine();
   }

}
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Thank you for playing!");
Console.ResetColor();