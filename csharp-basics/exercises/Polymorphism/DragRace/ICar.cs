using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface ICar
    {
        int SpeedUp();
        int SlowDown();
        int ShowCurrentSpeed();
        string StartEngine();
    }
}
