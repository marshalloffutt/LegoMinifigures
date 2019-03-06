using LegoMinifigures.Legos;
using LegoMinifigures.Legos.Heads;
using LegoMinifigures.Legos.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDogHead = new Dog();
            var martinHead = new Bald();
            var notAnAstro = new Astronaut();

            var fitTorso = new FitTorso(2, Gender.Male, Colors.Freckles);
            fitTorso.Crunch(22);

            var minifigure = new Minifigure(martinHead, fitTorso);

            minifigure.Greet();

            Console.ReadLine();
        }
    }
}
