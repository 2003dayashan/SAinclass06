using System;

namespace Robotfactorydemo
{
    public class EntertainmentRobot : Robot
    {
        // Unique Feature
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(string modelName, double batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            // Creates a shallow copy of the current instance
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"-> Entertainment Feature: {EntertainmentFeature}\n");
        }
    }
}