using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List <ISound> sounds = new List<ISound> {new Radio(), new Radio(), new Parrot(), new Parrot(), new Firework(), new Firework()};
            foreach (ISound el in sounds)
            {
                el.PlaySound();
            }
        }
    }
}