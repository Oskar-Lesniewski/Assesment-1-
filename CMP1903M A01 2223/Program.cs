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
                while (true)
                {
                    Console.WriteLine("Type in 1 for a Fisher-Yates Shuffle, 2 to Riffle Shuffle, and 3 for No Shuffle.");
                try
                {
                    int shuffle = Convert.ToInt32(Console.ReadLine());
                    if (shuffle < 1 || shuffle > 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine();
                        if (shuffle == 1)
                        {
                            Pack.shuffleCardPack(1);
                        }
                        else if (shuffle == 2)
                        {
                            Pack.shuffleCardPack(2);
                        }
                        else if (shuffle == 3)
                        {
                            Pack.shuffleCardPack(3);
                        }
                    }
                }
                catch
                { 
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;               
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }
}

