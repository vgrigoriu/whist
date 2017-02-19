using WhistCore;
using Xunit;

namespace Tests
{
    public class GetValidFollowUpsTests
    {
        [Fact]
        public void ReturnsAllCardsOfTheSameSuitWhenNoTrump()
        {
            var initialCard = new Card(Rank.Ace, Suit.Spades);
            var hand = new[]
            {
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Two, Suit.Hearts),
                new Card(Rank.Two, Suit.Spades),
                new Card(Rank.Five, Suit.Clubs),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Five, Suit.Hearts),
                new Card(Rank.Five, Suit.Spades),
            };

            var validCards = Rules.GetValidFollowUps(initialCard, null, hand);

            Assert.Equal(
                new[]
                {
                    new Card(Rank.Two, Suit.Spades),
                    new Card(Rank.Five, Suit.Spades),
                },
                validCards);
        }

        [Fact]
        public void ReturnsAllTrumpCardsWhenInitialCardMatchesTrump()
        {
            var initialCard = new Card(Rank.Ace, Suit.Spades);
            var trump = Suit.Spades;
            var hand = new[]
            {
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Two, Suit.Hearts),
                new Card(Rank.Two, Suit.Spades),
                new Card(Rank.Five, Suit.Clubs),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Five, Suit.Hearts),
                new Card(Rank.Five, Suit.Spades),
            };

            var validCards = Rules.GetValidFollowUps(initialCard, trump, hand);

            Assert.Equal(
                new[]
                {
                    new Card(Rank.Two, Suit.Spades),
                    new Card(Rank.Five, Suit.Spades),
                },
                validCards);
        }

        [Fact]
        public void ReturnsAllTrumpCardsWhenNoInitialSuitInHand()
        {
            var initialCard = new Card(Rank.Ace, Suit.Hearts);
            var trump = Suit.Diamonds;
            var hand = new[]
            {
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Two, Suit.Spades),
                new Card(Rank.Five, Suit.Clubs),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Five, Suit.Spades),
            };

            var validCards = Rules.GetValidFollowUps(initialCard, trump, hand);

            Assert.Equal(
                new[]
                {
                    new Card(Rank.Two, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Diamonds),
                },
                validCards);
        }
    }
}
