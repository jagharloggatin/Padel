using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        public List<Game> _games = new List<Game>();

        //logiskt fel
        public void SetPoint(Player player)
        {
            //lägg in till ny plats, loop

            for (int i = 0; i == _games.Count-1; i++)
            {
                _games[i].GamePoint(player);
                //_games[i].GamePoint(player);
            }

            //_games[0].GamePoint(player);
        }
    }
}
