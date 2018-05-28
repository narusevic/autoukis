using System.Collections.Generic;
using System.Linq;
using Autoukis.Models;

namespace Autoukis.Controllers
{
    public class RobotController
    {
        public List<Robotas> Robots { get; } //TODO Will be stored in database.

        public (Pozicija position, List<byte[]> view) CheckState(int robotId)
        {
            var robot = Robots.Find(x => x.Id == robotId);
            if (robot == null)
            {
                //The robot with a given id does not exist.
                //display a message!
                return (null, null);
            }
            if (robot.Alive()) return (robot?.TechninePriemone.Position, robot.Vaizdas);
            //TODO
            //else display a message that the robot have not returned a signal
            //and return nulls.
            return (null, null);
        }

        //The RobotSelectionForm does call this method. If list is empty
        //the notification will be displayed.
        //Else the list will be displayed in the form.
        public List<Robotas> GetAvailableRobots()
        {
            return Robots.Where(x => x.Prieinamumas).ToList();
        }

        public bool SendSignal(int robotId)
        {
            var robot = Robots.Find(x => x.Id == robotId);
            return robot.Alive();
        }
        
    }
}
