using System;

namespace Padel
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void GamePoint(Player player)
        {
            player.PlayerPoint();
        }

        public Score GameScore(Player player)
        {
            return player.Score;
        }

        public string ScoreString()
        {

            if (_player1.Score._Score >= 4 && _player2.Score._Score < (_player1.Score._Score + 2))
                return "Player 1 wins";

            else if (_player2.Score._Score >= 4 && _player1.Score._Score < (_player2.Score._Score + 2))
                return "Player 2 wins";

            return "You must continue playing";
        }
    }
}
