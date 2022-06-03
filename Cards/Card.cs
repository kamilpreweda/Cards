﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    internal class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }
        public string Name { get { return $"{Value} {Suit}"; } }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
