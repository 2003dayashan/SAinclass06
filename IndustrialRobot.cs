using System;

namespace Robotfactorydemo
{
    public class IndustrialRobot : Robot
    {
        // Unique Feature
        public string IndustrialTask { get; set; }

        public IndustrialRobot(string modelName, double batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            // Creates a shallow copy of the current instance
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"-> Industrial Task: {IndustrialTask}\n");
        }
    }
}