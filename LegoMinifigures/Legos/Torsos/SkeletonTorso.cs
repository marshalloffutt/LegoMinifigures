using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos.Torsos
{
    class SkeletonTorso : Torso
    {
        public SkeletonTorso(int numberOfArms)
            : base(numberOfArms, Gender.Other, Colors.Bone, "bony")
        {
        }

        public void Rattle()
        {
            Console.WriteLine("Rattle rattle...");
            Wave();
        }
    }
}
