using System;

namespace Robotfactorydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotFactory factory = new RobotFactory();

            // 1. Set up standard baseline prototypes
            factory.RegisterPrototype("StandardIndustrial", new IndustrialRobot("Titan-IR", 12.0, "v1.0.0", "Welding"));
            factory.RegisterPrototype("StandardService", new ServiceRobot("CareBot-SR", 8.0, "v2.1.0", "Hospitality Assisting"));
            factory.RegisterPrototype("StandardEntertainment", new EntertainmentRobot("JoyBot-ER", 6.0, "v1.5.0", "Dancing & Music"));

            Console.WriteLine("================ ORIGINAL PROTOTYPES ================\n");
            Robot originalService = factory.GetRobotClone("StandardService");
            originalService.DisplayInfo();

            // 2. Customer 1 Order: Custom Service Robot with upgraded battery & software
            Console.WriteLine("================ CUSTOMER 1 ORDER (CUSTOMIZED CLONE) ================\n");
            ServiceRobot customService = (ServiceRobot)factory.GetRobotClone("StandardService");
            customService.BatteryCapacity = 16.0;           // Upgraded battery
            customService.SoftwareVersion = "v2.2.0-beta";  // Updated software
            customService.ServiceTask = "Patient Care Assistance"; // Custom task
            customService.DisplayInfo();

            // 3. Customer 2 Order: Industrial Robot with updated software
            Console.WriteLine("================ CUSTOMER 2 ORDER (CUSTOMIZED CLONE) ================\n");
            IndustrialRobot customIndustrial = (IndustrialRobot)factory.GetRobotClone("StandardIndustrial");
            customIndustrial.SoftwareVersion = "v1.1.2";
            customIndustrial.IndustrialTask = "Heavy Automotive Assembly";
            customIndustrial.DisplayInfo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}