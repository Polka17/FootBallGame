using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Game
    {
        private Team teamOne;
        private Team teamTwo;
        public Team TeamOne
        {
            get { return teamOne; }
            set
            {
                if(teamOne.Players.Length != 11)
                {
                    throw new ArgumentException("Again, you can have only 11 players!!!");
                }
                else
                {
                    teamOne = value;
                }
            }
        }
        public Team TeamTwo
        {
            get { return teamTwo; }
            set
            {
                if (teamTwo.Players.Length == 11)
                {
                    teamTwo = value;
                }
                else
                {
                    throw new ArgumentException("Again, you can have only 11 players!!!");
                }
            }
        }
        public Referee[] Referee { get; set; }

        //I don't watch and don't understand football, but I am pretty sure they round the minutes, so a "whole number it is"
        public Dictionary<FootballPlayer, int> Goals { get; set; } 
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void AddGoals(FootballPlayer player, int minute)
        {
            int goalsTeamone = 0;
            int goalsTeamtwo = 0;
            //Sorry, but literally can't come up with another solution right now..
            //So close your eyes and let's pretend that a player can't duplicate in both teams....
            if (TeamOne.Players.Contains(player))
            {
                goalsTeamone++;
            }
            if(TeamTwo.Players.Contains(player))
            {
                goalsTeamtwo++;
            }

            Goals[player] = minute;

            Result = $" Team 1 {goalsTeamone} - {goalsTeamtwo} Team 2";

            if (goalsTeamone > goalsTeamtwo)
            {
                Winner = TeamOne;
            }
            if (goalsTeamone < goalsTeamtwo)
            {
                Winner = TeamTwo;
            }
            else
            {
                Winner = null;
            }
        }
        public void GameInfo()
        {
            Console.WriteLine("GAME INFO");

            Console.WriteLine("Team 1:");
            foreach (var player in TeamOne.Players)
            {
                Console.WriteLine($"{player.Name} - {player.Number}");
            }
            Console.WriteLine($"Coach 1: {TeamOne.Coach.Name}");

            Console.WriteLine("Team 2:");
            foreach (var player in TeamTwo.Players)
            {
                Console.WriteLine($"{player.Name} - {player.Number}");
            }
            Console.WriteLine($"Coach 2: {TeamTwo.Coach.Name}");

            Console.WriteLine("Goals:");
            foreach (var goals in Goals)
            {
                Console.WriteLine($"{goals.Key} - {goals.Value}");
            }

            Console.WriteLine($"Result: {Result}");

            Console.WriteLine($"Winner: {Winner}");
        }
    }
}
