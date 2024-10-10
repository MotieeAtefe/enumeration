using static enumeration.TrafficLightController;

namespace enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TrafficLightController trafficLightController = new TrafficLightController();
            trafficLightController.GetLightDescription();   

            trafficLightController.CurrentLight = TrafficLight.green;
            trafficLightController.GetLightDescription();

            trafficLightController.CurrentLight = TrafficLight.yellow;
            trafficLightController.GetLightDescription();
        }
    }
}