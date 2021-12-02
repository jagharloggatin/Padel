using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;
using System.Linq;

namespace PadelTest
{
    public class SetTest
    {
        [Fact]
        public void AddSets()
        {
            var player1 = new Player();
            var player2 = new Player();
            var game = new Game(player1, player2);

            var set = new Set();

            set._games.Add(new Game(player1, player2));

            set.SetPoint(player1);
            set.SetPoint(player1);
            set.SetPoint(player1);

            int expectedResult = 3;

            Assert.Equal(set._games[0].GameScore(player1), (game.GameScore(player1)));
            Assert.Equal(expectedResult, set._games[0].GameScore(player1)._Score);
        }

    }
}
