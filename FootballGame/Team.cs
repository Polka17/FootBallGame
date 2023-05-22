using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        static int plCount;
        private FootballPlayer[] players = new FootballPlayer[plCount];

        public FootballPlayer[] Players
        {
            get { return players; }
            set
            {
                if(players.Length >= 11 || players.Length <= 22)
                {
                    players = value;
                }
                else
                {
                    throw new ArgumentException("Either get some more kids to play or you have put the whole university ib one team *-*");
                }
            }
        }
        public Coach Coach { get; set; }


        // Average age of the players
        private double age;
        private double GetTeamAverageAge(FootballPlayer[] players)
        {
            foreach (var player in players)
            {
                age += player.Age;
            }
            return age / players.Count();
        }
        
    }
}
