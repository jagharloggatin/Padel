using System;

namespace Padel
{
    public class Player
    {
        private string _name;
        public string Name 
        {
            get => Name;
            set
            {
                if (Name == null)
                    throw new ArgumentException("can't set name to null");

                _name = value;
            }
        }
        public Score Score { get; set; } = new Score();

        public Player()
        {

        }
        
        public Player(string name)
        {
            Name = name;
        }
        
        public void ScorePoint()
        {
            Score.Increase();
        }
    }
}
