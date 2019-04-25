using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class RNDM
    {
        public static void Roller()
        {
            Console.WriteLine("Welcome High Roller! \nHow many sides are you rolling tonight?");

            int Xsides = int.Parse(Console.ReadLine());
            Console.WriteLine("Ready To Roll? \nYah or Nah?");
            string ready = Console.ReadLine();

            Random Die = new Random();

            int rolled = 2;
            while (ready == "Yah" && rolled == 2 || rolled == 1)
            {
                int Win = Die.Next(1, Xsides);
                Console.WriteLine(Win);
                rolled--;
            }
        }
    }
}
