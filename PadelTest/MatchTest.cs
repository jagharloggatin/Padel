using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class MatchTest
    {
        [Fact]
        public void CheckIf()
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");
            var set = new Set();

            var game = new Game(player1, player2);

            int numberOfSets = 6;
            var match = new Match(numberOfSets, player1, player2);

            game.GamePoint(player1);
            game.GamePoint(player1);

        }
    }
}
