using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingHardware;

namespace UnitTestProject
{
    [TestClass]
    public class MotionSensorRequirements
    {
       
        
        
        [TestMethod]
        public void PeopleCountShouldIncrementWhenAlarmIsDisabled()
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
            climateSystem.Update();
            climateSystem.Update();

            Assert.AreEqual(3, climateSystem.peopleCount);






        }

        [TestMethod]
        public void PeopleCountShouldntIncrementWhenAlarmIsEnabled()
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
            climateSystem.Update();
            climateSystem.Update();

            Assert.AreEqual(0, climateSystem.peopleCount);


        }
    }
}
