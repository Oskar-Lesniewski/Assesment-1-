using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> pack { get; set; }

        // Initialising the initial card pack
        public Pack()
        {
            pack = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));
            }
        }

        // Method for shuffling the cards
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher-Yates shuffle
            if (typeOfShuffle == 1)
            {
                // Randomly selecting items in a pack, adding to a new list and deleting the same item from the old pack
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
                // Dealing a card, calling the deal method
                deal(shuffledPack);
                return true;
            }
            // Riffle shuffle
            else if (typeOfShuffle == 2)
            {
                // Performing a riffle shuffle on the original set of cards
                Pack pack = new Pack();
                Random amount = new Random();
                Random side = new Random();
                int y = amount.Next(2, 24);
                for (int j = 0; j <= y; j++)
                {
                    int half = pack.pack.Count / 2;
                    List<Card> topHalf = pack.pack.GetRange(0, half);
                    List<Card> bottomHalf = pack.pack.GetRange(half, half);
                    List<Card> shuffledPack = new List<Card>();
                    int lor = side.Next(1, 2);
                    if (lor == 1)
                    {
                        for (int i = 0; i < half; i++)
                        {
                            shuffledPack.Add(topHalf[i]);
                            shuffledPack.Add(bottomHalf[i]);
                        }
                    }
                    else if (lor == 2)
                    {
                        for (int i = 0; i < half; i++)
                        {
                            shuffledPack.Add(bottomHalf[i]);
                            shuffledPack.Add(topHalf[i]);
                        }
                    }
                    pack.pack = shuffledPack;
                    if (j == y)
                    {
                        Console.WriteLine("Pack was shuffled " + j + " times.");
                        deal(shuffledPack);
                    }
                }
                // Dealing a card, calling the deal method
                return true;
            }
            // No shuffle
            else if (typeOfShuffle == 3)
            {
                Pack pack = new Pack();
                // Dealing a card, calling the deal method
                deal(pack.pack);
                return false;
            }
            else
            {
                return false;
            }
        }
        //Deal method
        public static Card deal(List<Card>list)
        {
            // Taking the first element of the shuffled list that the user picked, and dealing it to them
            var deal = list.Take(1);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            // Error handling to make sure the user selects the right amount of extra cards they want dealt
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to be dealt more cards? Please specify how many you wish to be dealt (0-52) ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 0 || amount > 52)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        // Calling the dealCard method to deal more cards as the user wishes
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
            return null;
        }
        // dealCard method
        private static List<Card> dealCard(int amount, List<Card>list)
        {
            // Deals the specified amount of cards the user wanted
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            return null;
        }
        // Testing purpouses only, same funtionality just displays the pack after each manipulation to make sure it is doing what it should
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
                Pack pack = new Pack();
                Random amount = new Random();
                Random side = new Random();
                int y = amount.Next(6, 12);
                for (int j = 0; j <= y; j++)
                {
                    int half = pack.pack.Count / 2;
                    List<Card> topHalf = pack.pack.GetRange(0, half);
                    List<Card> bottomHalf = pack.pack.GetRange(half, half);
                    List<Card> shuffledPack = new List<Card>();
                    int lor = side.Next(1, 2);
                    if (lor == 1)
                    {
                        for (int i = 0; i < half; i++)
                        {
                            shuffledPack.Add(topHalf[i]);
                            shuffledPack.Add(bottomHalf[i]);
                        }
                    }
                    else if (lor == 2)
                    {
                        for (int i = 0; i < half; i++)
                        {
                            shuffledPack.Add(bottomHalf[i]);
                            shuffledPack.Add(topHalf[i]);
                        }
                    }
                    pack.pack = shuffledPack;
                    shuffledPack.Reverse();
                    Console.WriteLine("Pack was shuffled.");
                    foreach (Card card in shuffledPack)
                    {
                        Console.WriteLine(card.Display());
                    }
                    if (j == y)
                    {
                        dealTest(shuffledPack);
                    }
                }
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
                    Console.WriteLine("Would you like to be dealt more cards? Please specify how many you wish to be dealt (0-52) ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 0 || amount > 52)
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
            return null;
        }
        private static List<Card> dealCardTest(int amount, List<Card> list)
        {
            var deal = list.Take(amount);
            foreach (Card card in deal)
            {
                Console.WriteLine("You have been Dealt - " + card.Display());
            }
            return null;
        }
    }
}

