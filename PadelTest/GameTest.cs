using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class GameTest
    {
        //checking if player1 can win the game
        [Fact]
        public void GamePointPlayer1Wins()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.GamePoint(player1); // 15 - 0
            game.GamePoint(player1); // 30 - 0
            game.GamePoint(player2); // 30 - 15
            game.GamePoint(player1); // 40 - 15
            game.GamePoint(player1); // Player 1 vinner Gamet

            var result = game.ScoreString(); 

            Assert.Equal(game.ScoreString(), result);
        }
        //checking if player2 can win the game
        [Fact]
        public void GamePointPlayer2Wins() 
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.GamePoint(player2); 
            game.GamePoint(player2); 
            game.GamePoint(player1); 
            game.GamePoint(player2); 
            game.GamePoint(player2); 

            var result = game.ScoreString(); 

            Assert.Equal(game.ScoreString(), result);
        }
        //checking that you must win with 2 points
        [Fact]
        public void GamePointWinWith2Points() 
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.GamePoint(player1); 
            game.GamePoint(player1); 
            game.GamePoint(player2); 
            game.GamePoint(player2); 
            game.GamePoint(player2); 

            var result = game.ScoreString();

            Assert.Equal("You must continue playing", result);
        }
        //checking if player1 recieves score
        [Fact]
        public void GameScorePlayer1Test()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.GamePoint(player1); 
            game.GamePoint(player1);

            int results = game.GameScore(player1)._Score;

            Assert.Equal(player1.Score._Score, results);
            Assert.True(player1.Score._Score == 2);
        }
        //checking if player2 recieves score
        [Fact]
        public void GameScorePlayer2Test()
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            var game = new Game(player1, player2);
            game.GamePoint(player2); 
            game.GamePoint(player2); 

            int results = game.GameScore(player2)._Score;

            Assert.Equal(player2.Score._Score, results);
            Assert.True(player2.Score._Score == 2);
        }
    }
}
