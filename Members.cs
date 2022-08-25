using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human2
{
    internal class Members
    {
        //member private field 
        private string memberName;
        private string jobTitle;
        private int salary;

        //public field
        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }

        }


        //public member method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, salary);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is: {0}", salary);

        }

        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("object Created");
        }

        // member finalizer or destructor
        ~Members()
        {
            Console.WriteLine("Destruction of Member object");
        }
    }

}

