using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingHardware;

namespace UnitTestProject
{
    [TestClass]
    public class HeatGeneratorRequirements
    {



        [TestMethod]
        public void PowerShouldbe50WhenTemperatureUnder20()        
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);
            stubTemperatureSensor.temperatureValue = 15;

            mockLockupSystem.Locked = false;

            climateSystem.Update();

            Assert.AreEqual(50, mockHeatGenerator.PowerValue);


        }

        public void PowerShouldbe100WhenTemperatureUnder10()
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);
            stubTemperatureSensor.temperatureValue = 5;

            mockLockupSystem.Locked = false;

            climateSystem.Update();

            Assert.AreEqual(100, mockHeatGenerator.PowerValue);
        }

        public void PowerShouldbe0WhenTemperatureAbove20()
        {
            MockAlarmSystem mockAlarmSystem = new MockAlarmSystem();
            MockHeatGenerator mockHeatGenerator = new MockHeatGenerator();
            MockLockupSystem mockLockupSystem = new MockLockupSystem();

            StubMotionSensor stubMotionSensor = new StubMotionSensor();
            StubTemperatureSensor stubTemperatureSensor = new StubTemperatureSensor();



            ClimateSystem climateSystem = new ClimateSystem(stubMotionSensor, stubTemperatureSensor, mockHeatGenerator, mockAlarmSystem, mockLockupSystem);
            stubTemperatureSensor.temperatureValue = 25;

            mockLockupSystem.Locked = false;

            climateSystem.Update();

            Assert.AreEqual(0, mockHeatGenerator.PowerValue);
        }
    }
}