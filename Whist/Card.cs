using System;

namespace Whist
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
    }
}
