using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Choise(int i)  
        {
            string[] RPS = new string[] { "ROCK", "PAPER", "SCISSORS" };
            return RPS[i];
        }
        public string Choise(string name) => name;
        
    }
}
