using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBlackJackTDD
{
    public class Deck
    {
        Random random;
        public Deck(){
            random = new Random();
        }

        public Card GetCard(){
            int rank = random.Next(1, 11);
            Card c = new Card(rank);
            return c;
        }
    }
}
