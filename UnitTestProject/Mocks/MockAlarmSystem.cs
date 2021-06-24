using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingHardware;
namespace UnitTestProject
{
    public class MockAlarmSystem : IAlarmSystem
    {
       public bool alarmValue;
        
        public void DisableAlarm()
        {
            alarmValue = false;
        }

        public void RingAlarm()
        {
            alarmValue = true;
        }
    }
}
