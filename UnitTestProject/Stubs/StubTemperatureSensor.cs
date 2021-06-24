using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingHardware;
namespace UnitTestProject
{
    public class StubTemperatureSensor : ITemperatureSensor
    {
        public float temperatureValue;
        
        public float GetTemperature()
        {
            return temperatureValue;
        }
    }
}
