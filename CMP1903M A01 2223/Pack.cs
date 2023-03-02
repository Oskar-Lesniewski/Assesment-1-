﻿using System;
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

                // Add any remaining cards to the end of the shuffledPack
                if (pack.pack.Count % 2 != 0)
                {
                    shuffledPack.Add(pack.pack[pack.pack.Count - 1]);
                }

                // Replace the pack with the shuffledPack
                pack.pack = shuffledPack;

                Console.WriteLine("Pack was shuffled:");
                foreach (Card card in pack.pack)
                {
                    Console.WriteLine(card.Display());
                }

                return true;
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