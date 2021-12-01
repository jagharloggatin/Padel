using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class ScoreTest
    {
        [Fact]
        public void ScoreIncrease()
        {
            Score score = new Score();

            score._Score = 2;
            int scoreExpectedResult = 2;

            Assert.Equal(scoreExpectedResult, score._Score);
        }

        [Fact]
        public void IncreaseScore()
        {
            var player1 = new Player();

            int player1ExpectedResult = 1;

            player1.Score.Increase();

            Assert.Equal(player1ExpectedResult, player1.Score._Score);
        }
    }
}
