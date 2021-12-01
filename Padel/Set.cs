using System;
using System.Collections.Generic;

namespace Padel
{
    public class Set
    {
        List<Game> _games = new List<Game>();


        //logiskt fel
        public void SetPoint(Player player)
        {
            _games[0].GamePoint(player);
        }
    }
}
