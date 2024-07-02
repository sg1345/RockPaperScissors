namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            var playerScore = 0;
            var computerScore = 0;
            var gamesPlayed = 0;

            while (true)
            {
                //Player chose rock, paper or scissors
                Console.Write("Choose Rock(r), Paper(p) or Scissors(s): ");
                var input = Console.ReadLine(); //Rock == r; Paper == p; Scissors == s; 

                var playerMove = input;
                if (playerMove == "Rock" || playerMove == "rock" ||
                    playerMove == "r"    || playerMove == "R"    )
                {
                    playerMove = "ROCK";
                }
                else if (playerMove == "Paper" || playerMove == "paper" ||
                         playerMove == "P"     || playerMove == "p")
                {
                    playerMove = "PAPER";
                }
                else if (playerMove == "Scissors" || playerMove == "scissors" ||
                         playerMove == "S"        || playerMove == "s")
                {
                    playerMove = "SCISSORS";
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

                if (computerMove == "ROCK"     && playerMove == "PAPER"    ||
                    computerMove == "PAPER"    && playerMove == "SCISSORS" ||
                    computerMove == "SCISSORS" && playerMove == "ROCK")
                {
                    playerScore++;
                    Console.Write("You win!             ");
                    Console.WriteLine($"Player {playerScore} : {computerScore} Computer");
                }
                else if (computerMove == "ROCK"     && playerMove == "SCISSORS" ||
                         computerMove == "PAPER"    && playerMove == "ROCK" ||
                         computerMove == "SCISSORS" && playerMove == "PAPER")
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

                gamesPlayed++;

                //Game exit/continue option
                Console.WriteLine("Do you want to continue? Y/N");
                
                while (true)
                {
                    input = Console.ReadLine(); // yes or no

                    if (input == "Yes" || input == "yes" || input == "Y" || input == "y")
                    {
                        break;
                    }
                    else if (input == "No" || input == "no" || input == "N" || input == "n")
                    {
                        Console.WriteLine($"Final result: Player {playerScore} : {computerScore} computer after {gamesPlayed} games. ");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter Y or N");
                        continue;
                    }

                }
            }

            
        }
    }
}
