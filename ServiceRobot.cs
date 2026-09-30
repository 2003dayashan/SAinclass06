using System;

namespace Robotfactorydemo
{
    public class ServiceRobot : Robot
    {
        // Unique Feature
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, double batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            // Creates a shallow copy of the current instance
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"-> Service Task: {ServiceTask}\n");
        }
    }
}