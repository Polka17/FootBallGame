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
                if (number >= 0)
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Are you for real giving someome a negarive jersey number, fella?");
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (height > 140 || height < 210)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Little shrimp or ginormious dinosaur!!!!");
                }
            }
        }
        public void EnterPlayerInfo()
        {
            Console.WriteLine("Enter the number:");
            Number = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the height:");
            Height = double.Parse(Console.ReadLine());
        }
    }
}
