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

        public string Type { get ; set; }

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
            return "какая то инфа о роботе. Было бы круто брать эту инфу из дефолтной реализации IFlyingRobot, но я не понимаю как это сделать и возможно ли";
        }

    }
}
