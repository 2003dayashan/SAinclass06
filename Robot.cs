using System;

namespace Robotfactorydemo
{
    public abstract class Robot
    {
        // Common Features
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; } // in hours
        public string SoftwareVersion { get; set; }

        public Robot(string modelName, double batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        // Prototype pattern cloning method
        public abstract Robot Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {ModelName} | Battery: {BatteryCapacity} hrs | Software: {SoftwareVersion}");
        }
    }
}