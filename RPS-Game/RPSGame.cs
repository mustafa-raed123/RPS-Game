using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public  class RPSGame
    {
        private string AIChoosing;
        private string PlayerChoosing;

        public RPSGame(string AIChosing , string PlayerChosing )
        {
            this.AIChoosing = AIChosing;
            this.PlayerChoosing = PlayerChosing;  
            
        }
        public string DetermineWinner()
        {
            if (AIChoosing == PlayerChoosing)
                return "It's a draw!";

            var winning = new Dictionary<string, string>
              {
                   { "ROCK", "SCISSORS" },       
                   { "SCISSORS", "PAPER" },            
                   { "PAPER", "ROCK" }                                
              };

            if (winning[PlayerChoosing] == AIChoosing)
            {
                
                return "you Win";
            }
            else
            {
                return "AI Win";
            }
        }
        public void UpdateScores(string result, Player player, Player AI)
        {
            if (result == "you Win")
            {
                player.Score++;

            }
            else if (result == "AI Win")
            {
                AI.Score++;
            }
            return;

        }
        public static void PrintWinner(int AIScore, int PlayerScore , string PlayerName)
        {
            if(AIScore > PlayerScore)
            {
                Console.WriteLine($"The AI wins the game! AI score: {AIScore}, Your score: {PlayerScore}.");
            }
            else if(PlayerScore > AIScore)
            {
                Console.WriteLine($"{PlayerName} wins the game! Your score: {PlayerScore}. AI score: {AIScore}.");

            }
            else
            {
                Console.WriteLine($"Both scores are the same.  Your score is {PlayerScore}. The AI score is {AIScore}.");
            }

        }

      

        }
}
