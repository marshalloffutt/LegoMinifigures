using LegoMinifigures.Legos.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos.Torsos
{
    abstract class Torso
    {
        public int NumberOfArms { get; protected set; }
        public string FitnessOfAbdomen { get; protected set; }
        public Gender Gender { get; protected set; }
        public Colors Color { get; protected set; }

        protected Torso(int numberOfArms, Gender gender, Colors color, string fitnessOfAbdomen)
        {
            NumberOfArms = numberOfArms;
            Gender = gender;
            Color = color;
            FitnessOfAbdomen = fitnessOfAbdomen;
        }

        public virtual void Wave()
        {
            Console.WriteLine("Waves hello 0/");
        }
    }

    internal enum Gender
    {
        Male, Female, Other
    }
}
