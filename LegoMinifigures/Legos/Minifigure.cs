using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Legos.Heads;
using LegoMinifigures.Legos.Torsos;
using LegoMinifigures.Legos.Legs;

namespace LegoMinifigures.Legos
{
    class Minifigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public LegsBase Legs { get; set; }

        public Minifigure(string name, Head head, Torso body, LegsBase legs )
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        public void Greet()
        {
            Head.Talk();
            Body.Wave();
        }

    }
}