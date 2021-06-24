using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingHardware
{
   public interface IMotionSensor
    {

        bool GetMovement();
        void Enable(bool enabled);
    }
}
