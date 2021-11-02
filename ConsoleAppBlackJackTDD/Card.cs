using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBlackJackTDD
{
    public class Card {
        public int Value { get; }

        public Card(int value){
            this.Value = value;
        }

        public override string ToString(){
            return Value.ToString();
        }
    }
}
