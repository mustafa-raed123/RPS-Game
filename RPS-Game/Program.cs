using System.Linq.Expressions;

namespace RPS_Game
{
    public class Program
    {
        static void Main(string[] args)
        {  
                Random random = new Random();
                Player AI = new Player();
                Player player = new Player();
                Console.Write("Enter Your Name: ");
                string PlayerName = Console.ReadLine();         
                player.Name = PlayerName;
                int i = 0;
                while (i < 3)
                {
                Console.WriteLine($"Round {i + 1}");
                int RandomNumber = random.Next(0, 3);
                    AI.Name = "AI";
                    string AIChoosing = AI.Choise(RandomNumber);
                    try
                    {
                
                     string PlayerChooing =GetPlayerChoice(player);
                   
                    RPSGame rpsgame = new RPSGame(AIChoosing, PlayerChooing);
                    rpsgame.UpdateScores(rpsgame.DetermineWinner(), player, AI);
                    Console.WriteLine($"the AI choosing {AIChoosing},\t and your choosing {PlayerChooing}.");
                    Console.WriteLine($"\n\t\t{rpsgame.DetermineWinner()}\n");
                    Console.WriteLine($" Your score is {player.Score} : AI score is {AI.Score}");
                    i++;
                }
                catch (Exception ex)
                    {                       
                        Console.WriteLine("Invalid input. You should enter a valid value.");
                    }
                }
                RPSGame.PrintWinner(AI.Score, player.Score, player.Name);               
        }
        static string GetPlayerChoice(Player  player)
        {
            Console.WriteLine("What do you want to choose: (ROCK OR 1 , PAPER OR  2, SCISSORS OR 3 )");
            string PlayerInput = Console.ReadLine().ToUpper();
            
            if (int.TryParse(PlayerInput, out int Choosing))
            {
                return  player.Choise(Choosing - 1);
            }
            else
            {
                return  player.Choise(PlayerInput);
            }
            return  null;
        }
   
    }
}
