using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingHardware
{
  public  interface IHeatGenerator
    {


        // power should be between 0 and 100
        void SetPower(int power);
    }
}
