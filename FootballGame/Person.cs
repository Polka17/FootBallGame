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
                    throw new ArgumentException("A name should be written");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(age < 12 || age > 45)
                {
                    throw new ArgumentException("Either too young or unbelievebly old to play :(");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
