using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingHardware
{
  public  class ClimateSystem
    {
        //sensor inputs
        IMotionSensor motionSensor;
        ITemperatureSensor temperatureSensor;


        // hardware outputs
        IHeatGenerator heatGenerator;
        IAlarmSystem alarmSystem;

        // both input and output
        ILockupSystem lockupSystem;


        public int peopleCount = 0;


       public ClimateSystem(IMotionSensor motion, ITemperatureSensor temperature, IHeatGenerator heat, IAlarmSystem alarm, ILockupSystem lockup) 
        {
            motionSensor = motion;
            temperatureSensor = temperature;
            heatGenerator = heat;
            alarmSystem = alarm;
            lockupSystem = lockup;
        }

      


        // updates the current Climate System state
        public void Update() 
        {
            if (lockupSystem.Locked)
            {
                heatGenerator.SetPower(0);
                motionSensor.Enable(false);


                if (motionSensor.GetMovement())
                {
                    alarmSystem.RingAlarm();
                }

                else 
                {
                    alarmSystem.DisableAlarm();
                }

            }

            else
            {
                motionSensor.Enable(true);


                if (temperatureSensor.GetTemperature() < 20)
                {
                    heatGenerator.SetPower(50);
                }

                else if (temperatureSensor.GetTemperature() < 10)
                {
                    heatGenerator.SetPower(100);
                }

                else 
                {
                    heatGenerator.SetPower(0);
                }

                if (motionSensor.GetMovement()) 
                {
                    peopleCount += 1;
                }


            }



        }
    }
}
