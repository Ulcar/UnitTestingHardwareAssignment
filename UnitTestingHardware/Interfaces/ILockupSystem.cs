using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingHardware
{
    
    // when the building is locked, alarms are enabled
   public interface ILockupSystem
    {
        void LockBuilding();
        void UnlockBuilding();

        bool Locked { get; }
    }
}
