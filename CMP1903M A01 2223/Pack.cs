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

                return true;
            }
            else if (typeOfShuffle == 2)
            {
                Random r = new Random();
                Pack pack = new Pack();
                List<Card> shuffledCards = new List<Card>();
                for (int i = pack.pack.Count(); i > 0; i--)
                {
                    int j = r.Next(i);
                    var temp = pack.pack[j];
                    shuffledCards.Add(temp);
                    pack.pack.RemoveAt(j);

                }
                foreach (Card card in shuffledCards)
                {
                    Console.WriteLine(card.Display());
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                return false;
            }
            else 
            { 
                return false; 
            }
        }
        public static Card deal()
        {
            return new Card(1);

        }
        public static List<Card> dealCard(int amount)
        {
            return new List<Card>();
        }
    }

}