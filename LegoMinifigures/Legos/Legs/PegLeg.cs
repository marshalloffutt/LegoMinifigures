using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos.Legs
{
    class PegLeg : LegsBase
    {
        public PegLeg(Length legLength) : base(legLength, Colors.Bone)
        {
        }

        public override void Jump()
        {
            Console.WriteLine($"The {(Hairy ? "hairy" : "")} peg legs don't jump.");
        }
    }
}
