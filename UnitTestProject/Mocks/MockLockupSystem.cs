using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingHardware;
namespace UnitTestProject
{
    public class MockLockupSystem : ILockupSystem
    {

        // public setter for mock testing
        public bool Locked { get; set; }

        public void LockBuilding()
        {
            Locked = true;
        }

        public void UnlockBuilding()
        {
            Locked = false;
        }
    }
}
