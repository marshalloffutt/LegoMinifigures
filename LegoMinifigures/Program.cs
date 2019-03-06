using LegoMinifigures.Legos;
using LegoMinifigures.Legos.Heads;
using LegoMinifigures.Legos.Torsos;
using LegoMinifigures.Legos.Legs;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDogHead = new Dog();

            myDogHead.Talk();

            var martinHead = new Bald();
            var notAnAstro = new Astronaut();

            var fitTorso = new FitTorso(2);
            fitTorso.Crunch(12);

            var adamsLegs = new OrangeLegs(Length.Short);

            var minifigure = new Minifigure("Adam", martinHead, fitTorso, adamsLegs);

            minifigure.Greet();

            Console.ReadLine();
        }
    }
}
