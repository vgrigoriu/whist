using StoryTeller;
using System.Linq;
using WhistCore;
using System;
using System.Collections.Generic;

namespace Whist.Storyteller
{
    public class ValidPlaysFixture : Fixture
    {
        private Card[] hand;

        private Suit? trump;

        private Card initialCard;

        public void TheTrumpIs(Suit trump)
        {
            this.trump = trump;
        }

        public void NoTrump()
        {
            trump = null;
        }

        [FormatAs("Your hand is {cards}")]
        public void YourHandIs(string cards)
        {
            hand = cards.Select(CharToCard).ToArray();
        }

        public void InitialCardIs(string card)
        {
            initialCard = CharToCard(card.Single());
        }

        public string ValidPlays()
        {
            return new string(Rules.GetValidFollowUps(initialCard, trump, hand).Select(CardToChar).ToArray());
        }

        private Card CharToCard(char card)
        {
            return new Card(Rank.Jack, Suit.Heart);
        }

        private char CardToChar(Card card)
        {
            return '🃜';
        }
    }
}
