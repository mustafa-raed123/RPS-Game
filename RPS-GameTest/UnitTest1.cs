
using Xunit;
using System.Runtime.CompilerServices;
using RPS_Game;
using System.Xml.Linq;
using System.Text;

namespace RPS_GameTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestWinner1()
        { 
            //Arrange
            string AICoosing = "ROCK";
            string PlayerChoosing  = "SCISSORS";
            RPSGame Round1 = new RPSGame(AICoosing, PlayerChoosing);

            //Act
            string  Win= Round1.DetermineWinner();

            //Assert
            Assert.Equal("AI Win", Win);        
        }
        [Fact]
        public void TestWinner2()
        {
            //Arrange
            string AICoosing = "SCISSORS";
            string PlayerChoosing = "ROCK";
            RPSGame Round1 = new RPSGame(AICoosing, PlayerChoosing);

            //Act
            string Win = Round1.DetermineWinner();

            //Assert
            Assert.Equal("you Win", Win);
        }
        [Fact]
        public void TestWinner3()
        {
            //Arrange
            string AICoosing = "SCISSORS";
            string PlayerChoosing = "SCISSORS";
            RPSGame Round1 = new RPSGame(AICoosing, PlayerChoosing);

            //Act
            string Win = Round1.DetermineWinner();

            //Assert
            Assert.Equal("It's a draw!", Win);
        }

        [Fact]
        public void TestScore()
        {
            // Arrange
            string AICoosing = "ROCK";
            string PlayerChoosing = "SCISSORS";
            RPSGame Round1 = new RPSGame(AICoosing, PlayerChoosing);
            Player AI = new Player();
            Player player = new Player();

            // Act
            string TheWin = Round1.DetermineWinner();
            Round1.UpdateScores(TheWin, player, AI);

            // Assert     
            Assert.Equal(1, AI.Score);   
           
        }

    }
}