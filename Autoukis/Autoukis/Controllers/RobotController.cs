using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Autoukis.Models;

namespace Autoukis.Controllers
{
    public class RobotController
    {
        public List<Robot> Robots { get; }

        public (Position position, List<byte[]> view) CheckState(int robotId)
        {
            var robot = Robots.Find(x => x.Id == robotId);
            return (robot.Position, robot.View);
        }

        public List<Robot> GetAvailableRobots()
        {
            return Robots.Where(x => x.Availability).ToList();
        }

        public void SendSignal(int robotId)
        {
            
        }
    }
}
