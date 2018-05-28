using System;
using System.Collections.Generic;

namespace Autoukis.Models
{
    public class Robot: TechnicalEquipment
    {
        public double BatteryLevel { get; set; }
        public bool Availability { get; set; }
        public List<byte[]> View { get; set; }

        public void GoTowardsBrokenEquipment(Position position)
        {
            //TODO Implement with Arduino.
        }

        public void Demount(int equipmentId)
        {
            //TODO Implement with Arduino.
        }

        public void DragToWarehouse(int equipmentId)
        {
            //TODO Implement with Arduino.
        }

        public bool Alive()
        {
            ///With probability 95%, the robot will receive the signal,
            /// and therefore it notifies the controller that it is alive.
            var random = new Random();
            var guess = random.Next(1, 101);
            return guess <= 95;
        }
    }
}
