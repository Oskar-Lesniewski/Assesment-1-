using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack { get; set; }


        public Pack()
        {
            pack = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                Random r = new Random();
                Pack pack = new Pack();
                List<Card> shuffledPack = new List<Card>();
                for (int New = pack.pack.Count(); New > 0; New--)
                {
                    int Old = r.Next(New);
                    var temp = pack.pack[Old];
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(Old);

                }
                pack.pack = shuffledPack;
                Console.WriteLine("Pack was shuffled.");
                deal(shuffledPack);
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                // Perform a perfect riffle shuffle
                Pack pack = new Pack();
                int half = pack.pack.Count / 2;
                List<Card> topHalf = pack.pack.GetRange(0, half);
                List<Card> bottomHalf = pack.pack.GetRange(half, half);
                List<Card> shuffledPack = new List<Card>();

                for (int i = 0; i < half; i++) 
                {
                    shuffledPack.Add(topHalf[i]);
                    shuffledPack.Add(bottomHalf[i]);
                }


                // Replace the pack with the shuffledPack
                pack.pack = shuffledPack;
                shuffledPack.Reverse();

                Console.WriteLine("Pack was shuffled.");
                deal(shuffledPack);
                return true;
            }
            
            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                deal(pack.pack);
                return false;
            }
            else
            {
                return false;
            }
        }
        public static Card deal(List<Card>list)
        {           
            var deal = list.Take(1);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to be dealt more cards? Please specify how many you wish to be dealt (1-52) ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 1 || amount > 52)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        dealCard(amount, list);
                    }                  
                }
                catch
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;
            }
            return new Card(1);
        }
        public static List<Card> dealCard(int amount, List<Card>list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            return new List<Card>();
        }
        public static bool shuffleCardPackTest(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                Random r = new Random();
                Pack pack = new Pack();
                List<Card> shuffledPack = new List<Card>();
                for (int New = pack.pack.Count(); New > 0; New--)
                {
                    int Old = r.Next(New);
                    var temp = pack.pack[Old];
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(Old);

                }
                pack.pack = shuffledPack;
                Console.WriteLine("Pack was shuffled:");
                foreach (Card card in pack.pack)
                {
                    Console.WriteLine(card.Display());
                }
                dealTest(shuffledPack);
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                // Perform a perfect riffle shuffle
                Pack pack = new Pack();
                int half = pack.pack.Count / 2;
                List<Card> topHalf = pack.pack.GetRange(0, half);
                List<Card> bottomHalf = pack.pack.GetRange(half, half);
                List<Card> shuffledPack = new List<Card>();

                for (int i = 0; i < half; i++)
                {
                    shuffledPack.Add(topHalf[i]);
                    shuffledPack.Add(bottomHalf[i]);
                }


                // Replace the pack with the shuffledPack
                pack.pack = shuffledPack;
                shuffledPack.Reverse();

                Console.WriteLine("Pack was shuffled:");
                foreach (Card card in pack.pack)
                {
                    Console.WriteLine(card.Display());
                }
                dealTest(shuffledPack);
                return true;
            }

            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                dealTest(pack.pack);
                return false;
            }
            else
            {
                return false;
            }
        }
        public static Card dealTest(List<Card> list)
        {
            var deal = list.Take(1);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to be dealt more cards? Please specify how many you wish to be dealt (1-52) ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 1 || amount > 52)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        dealCardTest(amount, list);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;
            }
            return new Card(1);
        }
        public static List<Card> dealCardTest(int amount, List<Card> list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            return new List<Card>();
        }
    }
}

