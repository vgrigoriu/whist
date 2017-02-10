using System.Collections.Generic;
using System.Linq;

namespace WhistCore
{
    public static class Rules
    {
        /// <summary>
        /// The other players must play a card of the same suit if possible.
        /// Any player who has no card of the suit led must play a trump if they can.
        /// A player who has no cards of the suit led and no trumps can discard any card.
        /// </summary>
        /// <param name="initialCard"></param>
        /// <param name="trump"></param>
        /// <param name="hand"></param>
        /// <returns></returns>
        public static IEnumerable<Card> GetValidFollowUps(
            Card initialCard,
            Suit? trump,
            IEnumerable<Card> hand)
        {
            return hand.Where(card => card.Suit == initialCard.Suit);
        }
    }
}
