using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingHardware;

namespace UnitTestProject
{
    public class StubMotionSensor : IMotionSensor
    {

        public bool enabledValue;

        public bool movementValue;
        public void Enable(bool enabled)
        {
            enabledValue = enabled;
        }

        public bool GetMovement()
        {
            return movementValue;
        }
    }
}
