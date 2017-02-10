using WhistCore;
using Xunit;

namespace Tests
{
    public class GetValidFollowUpsTests
    {
        [Fact]
        public void ReturnsAllCardsOfTheSameSuit()
        {
            var initialCard = new Card(Rank.Ace, Suit.Spade);
            var hand = new[]
            {
                new Card(Rank.Two, Suit.Club),
                new Card(Rank.Two, Suit.Diamond),
                new Card(Rank.Two, Suit.Heart),
                new Card(Rank.Two, Suit.Spade),
                new Card(Rank.Five, Suit.Club),
                new Card(Rank.Five, Suit.Diamond),
                new Card(Rank.Five, Suit.Heart),
                new Card(Rank.Five, Suit.Spade),
            };

            var validCards = Rules.GetValidFollowUps(initialCard, hand);

            Assert.Equal(
                new[]
                {
                    new Card(Rank.Two, Suit.Spade),
                    new Card(Rank.Five, Suit.Spade),
                },
                validCards);
        }
    }
}
