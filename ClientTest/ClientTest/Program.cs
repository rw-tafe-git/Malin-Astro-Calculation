using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/pipespacemaths";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            // Example test functions
            Console.WriteLine(channel.StarVelocity(500.1f, 500));

            Console.WriteLine(channel.StarDistance(0.547f));

            Console.WriteLine(channel.TemperatureInKelvin(27));

            Console.WriteLine(channel.EventHorizon(8.2 * Math.Pow(10, 36)));

            Console.ReadLine();
        }
    }
}
