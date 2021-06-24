using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingHardware;

namespace UnitTestProject
{
    [TestClass]
    public class AlarmSystemRequirements
    {



        [TestMethod]
        public void AlarmShouldBeTriggeredWhenAlarmIsEnabledAndMovementIsDetected()
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);


            mockLockupSystem.Locked = true;
            stubMotionSensor.movementValue = true;
            climateSystem.Update();

            Assert.AreEqual(true, mockAlarmSystem.alarmValue);
        }

        [TestMethod]
        public void AlarmShouldntBeTriggeredWhenAlarmIsDisabledAndMovementIsDetected()
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);


            mockLockupSystem.Locked = false;
            stubMotionSensor.movementValue = true;
            climateSystem.Update();

            Assert.AreEqual(false, mockAlarmSystem.alarmValue);
        }

        [TestMethod]
        public void AlarmShouldntBeTriggeredWhenAlarmIsEnabledAndMovementIsNotDetected()
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);


            mockLockupSystem.Locked = true;
            stubMotionSensor.movementValue = false;
            climateSystem.Update();

            Assert.AreEqual(false, mockAlarmSystem.alarmValue);
        }


    }
}