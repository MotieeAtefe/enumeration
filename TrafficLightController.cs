using System;
using System.Timers;

namespace enumeration
{
    public enum TrafficLight
    {
        red, green, yellow
    }
    internal class TrafficLightController
    {
        public TrafficLight CurrentLight { get; set; }
        public TrafficLightController()
        {
            CurrentLight = TrafficLight.red;
            
        }
        public void ChangeColor()
        {
            switch (CurrentLight)
            {

                case TrafficLight.red:
                    CurrentLight = TrafficLight.green;
                    break;
                case TrafficLight.yellow:
                    CurrentLight = TrafficLight.red;
                    break;
                case TrafficLight.green:
                    CurrentLight = TrafficLight.yellow;
                    break;
            }
        }
        public void DisplayColor()
        {
            Console.WriteLine($"The currenty is: {CurrentLight}");
        }

      
        





    }
}
