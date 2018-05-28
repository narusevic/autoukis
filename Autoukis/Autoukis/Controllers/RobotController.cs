using System.Collections.Generic;
using System.Linq;
using Autoukis.Models;

namespace Autoukis.Controllers
{
    public class RobotController
    {
        public List<Robot> Robots { get; } //TODO Will be stored in database.

        public (Position? position, List<byte[]> view) CheckState(int robotId)
        {
            var robot = Robots.Find(x => x.Id == robotId);
            if (robot == null)
            {
                //The robot with a given id does not exist.
                //display a message!
                return (null, null);
            }
            if (robot.Alive()) return (robot.Position, robot.View);
            //TODO
            //else display a message that the robot have not returned a signal
            //and return nulls.
            return (null, null);
        }

        //The RobotSelectionForm does call this method. If list is empty
        //the notification will be displayed.
        //Else the list will be displayed in the form.
        public List<Robot> GetAvailableRobots()
        {
            return Robots.Where(x => x.Availability).ToList();
        }

        public bool SendSignal(int robotId)
        {
            var robot = Robots.Find(x => x.Id == robotId);
            return robot.Alive();
        }
        
    }
}
