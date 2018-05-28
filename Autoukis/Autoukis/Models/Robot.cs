using System;
using System.Collections.Generic;

namespace Autoukis.Models
{
    public class Robotas
    {
        public int Id { get; set; }
        public double BaterijosLygis { get; set; }
        public bool Prieinamumas { get; set; }
        public List<byte[]> Vaizdas { get; set; }
        public TechninePriemone TechninePriemone { get; set; }

        public void GoTowardsBrokenEquipment(Pozicija position)
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
