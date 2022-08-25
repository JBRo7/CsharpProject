using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human2
{
    internal class Box
    {
        //member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;


        // type "prop" then tab twice. enter the int, and the name
        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                height = value;
            }
        }


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;

        }




        //Setters and getters
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }



        public int FrontSurface
        { get { return height * length; } 
          set { this.height = value; }  
        
        }



        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and Height is {1} and Width is {2}, and Volume is {3}", 
                length, height, Width, volume = length * height * Width);


        }

    }
}
