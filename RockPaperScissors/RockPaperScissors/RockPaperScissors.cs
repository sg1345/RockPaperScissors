namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            var playerScore = 0;
            var computerScore = 0;

            while (true)
            {
                //Player chose rock, paper or scissors
                Console.Write("Choose Rock(r), Paper(p) or Scissors(s): ");
                var input = Console.ReadLine(); //Rock == r; Paper == p; Scissors == s; 

                if (input == "Rock" || input == "rock" ||
                    input == "r"    || input == "R"    )
                {
                    input = "ROCK";
                }
                else if (input == "Paper" || input == "paper" ||
                         input == "P"     || input == "p")
                {
                    input = "PAPER";
                }
                else if (input == "Scissors" || input == "scissors" ||
                         input == "S"        || input == "s")
                {
                    input = "SCISSORS";
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    continue;
                }


                //Computer choose rock, paper or scissors
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = "ROCK";
                        break;
                    case 2:
                        computerMove = "PAPER";
                        break;
                    case 3:
                        computerMove = "SCISSORS";
                        break;
                }

                //Game time! Result comparison
                Console.WriteLine($"GAME TIME:   (Computer)  {computerMove} vs {input} (Player)");

                if (computerMove == "ROCK"     && input == "PAPER"    ||
                    computerMove == "PAPER"    && input == "SCISSORS" ||
                    computerMove == "SCISSORS" && input == "ROCK")
                {
                    playerScore++;
                    Console.Write("You win!             ");
                    Console.WriteLine($"Player {playerScore} : {computerScore} Computer");
                }
                else if (computerMove == "ROCK"     && input == "SCISSORS" ||
                         computerMove == "PAPER"    && input == "ROCK" ||
                         computerMove == "SCISSORS" && input == "PAPER")
                {
                    computerScore++;
                    Console.Write("You lose!            ");
                    Console.WriteLine($"Player {playerScore} : {computerScore} Computer");
                }
                else
                {
                    Console.Write("Draw!                ");
                    Console.WriteLine($"Player {playerScore} : {computerScore} Computer");
                }

                //Game exit/continue option
                Console.WriteLine("Do you want to continue? Y/N");
                bool isFinished = false;
                while (true)
                {
                    input = Console.ReadLine(); // yes or no

                    if (input == "Yes" || input == "yes" || input == "Y" || input == "y")
                    {
                        break;
                    }
                    else if (input == "No" || input == "no" || input == "N" || input == "n")
                    {
                        isFinished = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                }
                if (isFinished) 
                {
                    break;
                }
            }

            Console.WriteLine($"Final result: Player {playerScore} : {computerScore} computer ");
        }
    }
}
