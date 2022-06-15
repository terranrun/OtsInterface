using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtsInter
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<object> _components = new List<object>{"rotor1","rotor2","rotor3","rotor4"};

        public void Charge()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Charging...");
        }

        public List<object> GetComponents()
        {
            return _components;
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public string GetRobotType(string s = "I am a simple robot")
        {
            throw new NotImplementedException();
        }
    }
}
