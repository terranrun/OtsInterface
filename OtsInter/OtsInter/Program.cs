
using OtsInter;
Quadcopter robot = new Quadcopter();


robot.Charge();
Console.WriteLine(robot.GetInfo());
Console.WriteLine(((IFlyingRobot)robot).GetRobotType());
Console.ReadLine();

