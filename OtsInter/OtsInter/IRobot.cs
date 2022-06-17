using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtsInter
{
    internal interface IRobot
    {
        string GetInfo();
        List<object> GetComponents();
        string GetRobotType() => "I am a simple robot";
    }
}
