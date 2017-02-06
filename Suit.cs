using System;
using System.ComponentModel;

namespace Whist
{
    public enum Suit
    {
        [Description("♣")]
        Club,

        [Description("♦")]
        Diamond,

        [Description("♥")]
        Heart,

        [Description("♠")]
        Spade
    }
}
