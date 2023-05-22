using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    //making the class abstract since we don't want instances :)
    public abstract class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("A name should be written");
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(age > 12 || age < 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Either too young or unbelievebly old to play :(");
                }
            }
        }
        public void EnterPersonInfo()
        {
            Console.WriteLine("Enter the name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            Age = int.Parse(Console.ReadLine());
        }
    }
}
