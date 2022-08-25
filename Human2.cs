using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human2
{
    class Human2
    {
        // members 
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Defult constructor
        public Human2()
        {
            Console.WriteLine("Constructor called. Object created");

        }

        public Human2(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }


        //parameterized constructor
        public Human2(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member
        public void IntroduceMyself()
        {
            if (age != 0)
                Console.WriteLine("Hi {0} {1}, your eye color is: {2}, and you are {3} years old!", firstName, lastName, eyeColor, age);
            else
                Console.WriteLine("Hi {0} {1}, your eye color is: {2}!", firstName, lastName, eyeColor);


        }
    }
}
