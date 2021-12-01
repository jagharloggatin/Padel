using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class PlayerTest
    {

        [Fact]
        public void PlayerNameSet()
        {
            var player1 = new Player();

            player1.Name = "Player1";

            Assert.Contains("Player1", player1.Name);
        }

        [Fact]
        public void PlayerNameNull()
        {
            var player1 = new Player("Player1");

            player1.Name = null;

            Assert.Null(player1.Name);
        }

        [Fact]
        public void PlayerNameEmpty()
        {
            var player1 = new Player("Player1");

            player1.Name = "";

            Assert.Empty(player1.Name);
        }

        [Fact]
        public void PlayerNameNotNull()
        {
            var player1 = new Player("Player1");

            Assert.NotNull(player1.Name);
        }
    }
}
