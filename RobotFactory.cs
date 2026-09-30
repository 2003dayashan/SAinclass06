using System.Collections.Generic;

namespace Robotfactorydemo
{
    public class RobotFactory
    {
        private readonly Dictionary<string, Robot> _prototypes = new Dictionary<string, Robot>();

        // Register default prototype configurations
        public void RegisterPrototype(string key, Robot prototype)
        {
            _prototypes[key] = prototype;
        }

        // Clone and return a robot by key
        public Robot GetRobotClone(string key)
        {
            if (_prototypes.ContainsKey(key))
            {
                return _prototypes[key].Clone();
            }

            return null;
        }
    }
}