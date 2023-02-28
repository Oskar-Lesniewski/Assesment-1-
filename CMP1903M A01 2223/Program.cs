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
            Card[] deck = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                deck[i] = new Card(i);
            }
        }   
    }
}
