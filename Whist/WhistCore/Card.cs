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
            ["🂡"] = new Card(Rank.Ace,   Suit.Spades),
            ["🂢"] = new Card(Rank.Two,   Suit.Spades),
            ["🂣"] = new Card(Rank.Three, Suit.Spades),
            ["🂤"] = new Card(Rank.Four,  Suit.Spades),
            ["🂥"] = new Card(Rank.Five,  Suit.Spades),
            ["🂦"] = new Card(Rank.Six,   Suit.Spades),
            ["🂧"] = new Card(Rank.Seven, Suit.Spades),
            ["🂨"] = new Card(Rank.Eight, Suit.Spades),
            ["🂩"] = new Card(Rank.Nine,  Suit.Spades),
            ["🂪"] = new Card(Rank.Ten,   Suit.Spades),
            ["🂫"] = new Card(Rank.Jack,  Suit.Spades),
            ["🂭"] = new Card(Rank.Queen, Suit.Spades),
            ["🂮"] = new Card(Rank.King,  Suit.Spades),

            // hearts
            ["🂱"] = new Card(Rank.Ace,   Suit.Hearts),
            ["🂲"] = new Card(Rank.Two,   Suit.Hearts),
            ["🂳"] = new Card(Rank.Three, Suit.Hearts),
            ["🂴"] = new Card(Rank.Four,  Suit.Hearts),
            ["🂵"] = new Card(Rank.Five,  Suit.Hearts),
            ["🂶"] = new Card(Rank.Six,   Suit.Hearts),
            ["🂷"] = new Card(Rank.Seven, Suit.Hearts),
            ["🂸"] = new Card(Rank.Eight, Suit.Hearts),
            ["🂹"] = new Card(Rank.Nine,  Suit.Hearts),
            ["🂺"] = new Card(Rank.Ten,   Suit.Hearts),
            ["🂻"] = new Card(Rank.Jack,  Suit.Hearts),
            ["🂽"] = new Card(Rank.Queen, Suit.Hearts),
            ["🂾"] = new Card(Rank.King,  Suit.Hearts),

            // diamonds
            ["🃁"] = new Card(Rank.Ace,   Suit.Diamonds),
            ["🃂"] = new Card(Rank.Two,   Suit.Diamonds),
            ["🃃"] = new Card(Rank.Three, Suit.Diamonds),
            ["🃄"] = new Card(Rank.Four,  Suit.Diamonds),
            ["🃅"] = new Card(Rank.Five,  Suit.Diamonds),
            ["🃆"] = new Card(Rank.Six,   Suit.Diamonds),
            ["🃇"] = new Card(Rank.Seven, Suit.Diamonds),
            ["🃈"] = new Card(Rank.Eight, Suit.Diamonds),
            ["🃉"] = new Card(Rank.Nine,  Suit.Diamonds),
            ["🃊"] = new Card(Rank.Ten,   Suit.Diamonds),
            ["🃋"] = new Card(Rank.Jack,  Suit.Diamonds),
            ["🃍"] = new Card(Rank.Queen, Suit.Diamonds),
            ["🃎"] = new Card(Rank.King,  Suit.Diamonds),

            // clubs
            ["🃑"] = new Card(Rank.Ace,   Suit.Clubs),
            ["🃒"] = new Card(Rank.Two,   Suit.Clubs),
            ["🃓"] = new Card(Rank.Three, Suit.Clubs),
            ["🃔"] = new Card(Rank.Four,  Suit.Clubs),
            ["🃕"] = new Card(Rank.Five,  Suit.Clubs),
            ["🃖"] = new Card(Rank.Six,   Suit.Clubs),
            ["🃗"] = new Card(Rank.Seven, Suit.Clubs),
            ["🃘"] = new Card(Rank.Eight, Suit.Clubs),
            ["🃙"] = new Card(Rank.Nine,  Suit.Clubs),
            ["🃚"] = new Card(Rank.Ten,   Suit.Clubs),
            ["🃛"] = new Card(Rank.Jack,  Suit.Clubs),
            ["🃝"] = new Card(Rank.Queen, Suit.Clubs),
            ["🃞"] = new Card(Rank.King,  Suit.Clubs),
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
