using LegoMinifigures.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Gender gender = Gender.Other, Colors color = Colors.Red)
            : base(numberOfArms, gender, color, "OMG, so fit.")
        {
        }

        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbdomen = FitnessOfAbdomen + " even more fit.";
            Console.WriteLine($"I just did {howManyCrunches}, brah. CROSSFIT!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("(ツ)_/¯");
        }
    }
}
