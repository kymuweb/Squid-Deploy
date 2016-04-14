using System;
using System.ServiceModel;


namespace TentacleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost TentacleHost = new ServiceHost(typeof(TentacleService.TentacleService)))
            {
                TentacleHost.Open();
                //Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                //Console.ReadLine();
                while (true) {
                    System.Threading.Thread.Sleep(50);
                }
            }
        }
    }
}
