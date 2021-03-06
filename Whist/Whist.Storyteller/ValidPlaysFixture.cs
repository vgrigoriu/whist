using StoryTeller;
using System.Linq;
using WhistCore;

namespace Whist.Storyteller
{
    public class ValidPlaysFixture : Fixture
    {
        private Card[] hand;

        private Suit? trump;

        private Card initialCard;

        [FormatAs("The trump is {trump}")]
        public void TheTrumpIs(Suit trump)
        {
            this.trump = trump;
        }

        [FormatAs("There is no trump")]
        public void NoTrump()
        {
            trump = null;
        }

        [FormatAs("Your hand is {cards}")]
        public void YourHandIs(string cards)
        {
            hand = cards.AsCodePoints().Select(Card.FromChar).ToArray();
        }

        [FormatAs("The initial card played is {card}")]
        public void InitialCardIs(string card)
        {
            initialCard = Card.FromChar(card);
        }

        [FormatAs("The valid plays are {value}")]
        public string ValidPlays()
        {
            var validPlays = Rules.GetValidFollowUps(initialCard, trump, hand);
            return string.Join(string.Empty, validPlays.Select(Card.ToChar));
        }
    }
}
