using LegoMinifigures.Legos.Heads;
using LegoMinifigures.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legos
{
    class Minifigure
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }
        //Legs

        public Minifigure(Head head, Torso body)
        {
            Head = head;
            Body = body;
        }

        public void Greet()
        {
            Head.Talk();
            Body.Wave();
        }

    }
}