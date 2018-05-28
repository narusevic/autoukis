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
            
        }

        public void Demount(int equipmentId)
        {
            
        }

        public void DragToWarehouse(int equipmentId)
        {
            
        }

        public void Alive()
        {
            
        }
    }
}
