using System.Collections.Generic;
using System.Linq;

namespace WhistCore
{
    public static class Rules
    {
        public static IEnumerable<Card> GetValidFollowUps(
            Card initialCard,
            Suit? trump,
            IEnumerable<Card> hand)
        {
            return hand.Where(card => card.Suit == initialCard.Suit);
        }
    }
}
