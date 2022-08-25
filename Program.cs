using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Human2
{
    class Program
    {
        static void Main(string[] args)

        {
            Human2 Denis = new Human2("Denis", "Wonder", "Green", 1);
            Human2 Michael = new Human2("Michel", "Johnson", "Blue");
            Human2 Ron = new Human2("Ron", "Swanson", "Brown", 24);
            Denis.IntroduceMyself();
            Michael.IntroduceMyself();
            Ron.IntroduceMyself();


            Human2 basicHuman = new Human2();
            basicHuman.IntroduceMyself();


            //instance of a class Box
            Box box = new Box(3, 4, 6);

            Console.WriteLine("Box volume is " + box.Volume);
            Console.WriteLine("Height = " + box.Height);
            Console.WriteLine("Width= " + box.Width);
            box.Width = 12;
            Console.WriteLine("Width= " + box.Width);

            Console.WriteLine("Front surface of box is {0}", box.FrontSurface);


            box.DisplayInfo();


            //Console.ReadKey();


            Members member1 = new Members();
            member1.Introducing(true);


        }


    }

}