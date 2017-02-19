using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WhistCore
{
    public sealed class Card : IEquatable<Card>
    {
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Rank Rank { get; }
        public Suit Suit { get; }

        public bool Equals(Card other)
        {
            return other != null && Rank == other.Rank && Suit == other.Suit;
        }

        public override bool Equals(object other)
        {
            return Equals(other as Card);
        }

        public override int GetHashCode()
        {
            return Rank.GetHashCode() ^ Suit.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }

        private static readonly Dictionary<string, Card> cards = new Dictionary<string, Card>
        {
            // spades
            ["🂡"] = new Card(Rank.Ace,   Suit.Spade),
            ["🂢"] = new Card(Rank.Two,   Suit.Spade),
            ["🂣"] = new Card(Rank.Three, Suit.Spade),
            ["🂤"] = new Card(Rank.Four,  Suit.Spade),
            ["🂥"] = new Card(Rank.Five,  Suit.Spade),
            ["🂦"] = new Card(Rank.Six,   Suit.Spade),
            ["🂧"] = new Card(Rank.Seven, Suit.Spade),
            ["🂨"] = new Card(Rank.Eight, Suit.Spade),
            ["🂩"] = new Card(Rank.Nine,  Suit.Spade),
            ["🂪"] = new Card(Rank.Ten,   Suit.Spade),
            ["🂫"] = new Card(Rank.Jack,  Suit.Spade),
            ["🂭"] = new Card(Rank.Queen, Suit.Spade),
            ["🂮"] = new Card(Rank.King,  Suit.Spade),

            // hearts
            ["🂱"] = new Card(Rank.Ace,   Suit.Heart),
            ["🂲"] = new Card(Rank.Two,   Suit.Heart),
            ["🂳"] = new Card(Rank.Three, Suit.Heart),
            ["🂴"] = new Card(Rank.Four,  Suit.Heart),
            ["🂵"] = new Card(Rank.Five,  Suit.Heart),
            ["🂶"] = new Card(Rank.Six,   Suit.Heart),
            ["🂷"] = new Card(Rank.Seven, Suit.Heart),
            ["🂸"] = new Card(Rank.Eight, Suit.Heart),
            ["🂹"] = new Card(Rank.Nine,  Suit.Heart),
            ["🂺"] = new Card(Rank.Ten,   Suit.Heart),
            ["🂻"] = new Card(Rank.Jack,  Suit.Heart),
            ["🂽"] = new Card(Rank.Queen, Suit.Heart),
            ["🂾"] = new Card(Rank.King,  Suit.Heart),

            // diamonds
            ["🃁"] = new Card(Rank.Ace,   Suit.Diamond),
            ["🃂"] = new Card(Rank.Two,   Suit.Diamond),
            ["🃃"] = new Card(Rank.Three, Suit.Diamond),
            ["🃄"] = new Card(Rank.Four,  Suit.Diamond),
            ["🃅"] = new Card(Rank.Five,  Suit.Diamond),
            ["🃆"] = new Card(Rank.Six,   Suit.Diamond),
            ["🃇"] = new Card(Rank.Seven, Suit.Diamond),
            ["🃈"] = new Card(Rank.Eight, Suit.Diamond),
            ["🃉"] = new Card(Rank.Nine,  Suit.Diamond),
            ["🃊"] = new Card(Rank.Ten,   Suit.Diamond),
            ["🃋"] = new Card(Rank.Jack,  Suit.Diamond),
            ["🃍"] = new Card(Rank.Queen, Suit.Diamond),
            ["🃎"] = new Card(Rank.King,  Suit.Diamond),

            // clubs
            ["🃑"] = new Card(Rank.Ace,   Suit.Club),
            ["🃒"] = new Card(Rank.Two,   Suit.Club),
            ["🃓"] = new Card(Rank.Three, Suit.Club),
            ["🃔"] = new Card(Rank.Four,  Suit.Club),
            ["🃕"] = new Card(Rank.Five,  Suit.Club),
            ["🃖"] = new Card(Rank.Six,   Suit.Club),
            ["🃗"] = new Card(Rank.Seven, Suit.Club),
            ["🃘"] = new Card(Rank.Eight, Suit.Club),
            ["🃙"] = new Card(Rank.Nine,  Suit.Club),
            ["🃚"] = new Card(Rank.Ten,   Suit.Club),
            ["🃛"] = new Card(Rank.Jack,  Suit.Club),
            ["🃝"] = new Card(Rank.Queen, Suit.Club),
            ["🃞"] = new Card(Rank.King,  Suit.Club),
        };

        public static Card FromChar(string character)
        {
            return cards[character];
        }

        public static string ToChar(Card card)
        {
            return cards.Single(pair => card == pair.Value).Key;
        }
    }

    public static class StringExtensions
    {
        public static IEnumerable<string> AsCodePoints(this string s)
        {
            var e = StringInfo.GetTextElementEnumerator(s);
            while (e.MoveNext())
            {
                yield return e.GetTextElement();
            }
        }
    }
}
