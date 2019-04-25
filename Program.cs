using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wave = 1;
            while (Wave == 1)
            {
                RNDM.Roller();
                Console.WriteLine("Would you like to go again? \nYah or Nah?");
                Wave++;
                string yes = null;
                yes = Console.ReadLine();
                if (yes == "Yah")
                {
                    Wave--;
                }
                if (yes == "Nah")
                {
                    Console.WriteLine("Hope You Have A Good Day!");
                }

            }
            
            
        }
    }
}
