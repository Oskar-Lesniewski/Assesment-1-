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
            Console.WriteLine("Type in 1 to riffle shuffle, 2 for a Fisher-yates shuffle, and 3 for no shuffle.");
            string shuffle = Console.ReadLine();
            Console.WriteLine();
            if (shuffle == "1")
            {
                bool shuffleResult = Pack.shuffleCardPack(1);
                if (shuffleResult)
                {
                    Console.WriteLine("Pack shuffled successfully!");
                }
                else
                {
                    Console.WriteLine("Pack shuffle failed.");
                }
            }
            else if (shuffle == "2")
            {
                bool shuffleResult = Pack.shuffleCardPack(2);
                if (shuffleResult)
                {
                    Console.WriteLine("Pack shuffled sucessfully!");
                }
                else
                {
                    Console.WriteLine("Pack shuffle failed.");
                }
            }
            else if (shuffle == "3")
            {
                Console.WriteLine("Pack has not been shuffled");
            }
            


            Console.ReadLine();

        }
    }
}

