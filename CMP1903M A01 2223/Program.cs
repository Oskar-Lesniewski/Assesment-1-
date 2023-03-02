using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            Console.WriteLine("Initial pack:");
            foreach (Card card in pack.pack)
            {
                Console.WriteLine(card.Display());
            }

            // Shuffle the pack
            bool shuffleResult = Pack.shuffleCardPack(1);
            if (shuffleResult)
            {
                Console.WriteLine("Pack shuffled successfully!");
            }
            else
            {
                Console.WriteLine("Pack shuffle failed.");
            }


            Console.ReadLine();

        }
    }
}

