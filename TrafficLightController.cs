using System;
using System.Timers;

namespace enumeration
{
    internal class TrafficLightController
    {
      
        public enum TrafficLight
        {
            red, green, yellow
        }
        public TrafficLight CurrentLight { get; set; }
        public TrafficLightController()
        {
            CurrentLight = TrafficLight.red;
            
        }
        public void GetLightDescription()
        {
            switch (CurrentLight)
            {
                case TrafficLight.red:
                    Console.WriteLine("Stop! The light is red.");
                    break;
                case TrafficLight.yellow:
                    Console.WriteLine("Caution! The light is yellow.");
                    break;
                case TrafficLight.green:
                    Console.WriteLine("Go! The light is green.");
                    break;
                default:
                    Console.WriteLine("Unknown light state.");
                    break;
            }
        }

      
        





    }
}
