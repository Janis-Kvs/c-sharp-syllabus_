using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Krrrrrr");
        }
    }
}
