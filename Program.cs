using static enumeration.TrafficLightController;

namespace enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TrafficLightController trafficLightController = new TrafficLightController();
            for(int i=0; i< 5; i++) 
            {
                trafficLightController.DisplayColor();
                Console.WriteLine("if You want change trafficLigting press Enter");
                Console.ReadLine();
                trafficLightController.ChangeColor();
                

            }
        }
            
    }
}