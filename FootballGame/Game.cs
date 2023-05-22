using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Game
    {
        public Team TeamOne { get; set; }
        public Team TeamTwo { get; set; }
        public Referee[] Referee { get; set; }

        //I hope this does the job, beacuse initially I started with a class, but I saw we have to model only the given ones
        public Dictionary<FootballPlayer, int> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

    }
}
