using System;

namespace Padel
{
    public class Player
    {
        public string Name;

        public Score Score { get; set; } = new Score();

        public Player()
        {

        }
        
        public Player(string name)
        {
            Name = name;
        }
        
        public void PlayerPoint()
        {
            Score.Increase();
        }

        public void SetPlayerName(string name) 
        {
            if (name == null)
                throw new ArgumentException("can't set name to null");

            Name = name;
        }
    }
}
