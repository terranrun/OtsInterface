﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtsInter
{
    internal interface IFlyingRobot : IRobot
    { 
      public string GetRobotType() => "I am a flying robot";
    }
}
