using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingHardware;

namespace UnitTestProject
{
    class MockHeatGenerator : IHeatGenerator
    {
        public int PowerValue { get; set; }
        
        public void SetPower(int power)
        {
            PowerValue = power;
        }
    }
}
