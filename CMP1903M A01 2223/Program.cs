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
            // Shuffle the pack           
                while (true)
                {
                    // Type of shuffle wanted
                    Console.WriteLine("Type in 1 for a Fisher-Yates Shuffle, 2 to Riffle Shuffle, and 3 for No Shuffle. (4 for testing)");
                // Error handling
                try
                {
                    int shuffle = Convert.ToInt32(Console.ReadLine());
                    if (shuffle < 1 || shuffle > 4)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        // Calling specified shuffle method
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
                        else if (shuffle == 4)
                        {
                            Testing.MainTest();
                        }
                    }
                }
                // Catching the error, if there is one
                catch
                { 
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;               
            }
            // Quitting the program
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }
}

