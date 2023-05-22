using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    //making the class abstract since we don't want instances again :)
    public abstract class FootballPlayer : Person
    {

        private int number;
        private double height;

        public int Number
        {
            get { return number; }
            set
            {
                if (number <= 0)
                {
                    throw new ArgumentException("Are you for real giving someome a negarive jersey number, fella?");
                }
                else
                {
                    number = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (height <= 140 || height > 210)
                {
                    throw new ArgumentException("Little shrimp or ginormious dinosaur!!!!");
                }
                else
                {
                    height = value;
                }
            }
        }
    }
}
