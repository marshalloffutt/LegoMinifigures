using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos.Heads
{
    class Bald : Head
    {
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }

        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public override string Talk()
        {
            return "I have no hair!";
        }
    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }

}
