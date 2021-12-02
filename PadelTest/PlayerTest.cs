using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Padel;

namespace PadelTest
{
    public class PlayerTest
    {
        //setting playername
        [Fact]
        public void PlayerNameSet()
        {
            var player1 = new Player();

            player1.Name = "Player1";

            Assert.Contains("Player1", player1.Name);
        }
        //setting playername to null
        [Fact]
        public void PlayerNameNull()
        {
            var player1 = new Player("Player1");

            player1.Name = null;

            Assert.Null(player1.Name);
        }
        //setting playername
        [Fact]
        public void PlayerNameEmpty()
        {
            var player1 = new Player("Player1");

            player1.Name = "";

            Assert.Empty(player1.Name);
        }

        //Playername can't be set to null
        [Fact]
        public void PlayerNameCantBeNull()
        {
            var player1 = new Player("Player1");

            Action act = () => player1.SetPlayerName(null);

            Assert.Throws<ArgumentException>(act);
        }
        //Checking if playername is not null
        [Fact]
        public void PlayerNameNotNull()
        {
            var player1 = new Player("Player1");

            Assert.NotNull(player1.Name);
        }
    }
}
