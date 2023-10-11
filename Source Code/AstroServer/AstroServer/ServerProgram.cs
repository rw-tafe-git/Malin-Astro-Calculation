using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMath;

namespace AstroServer
{
    internal class ServerProgram
    {
        // Student Riley, id 30002737, Date: 23/08/2023
        // Assessment Task 2

        /// <summary>
        /// Server application
        /// </summary>

        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/pipespacemaths";

            ServiceHost serviceHost = new ServiceHost(typeof(ServerLMP));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();

            AstroMathFunctions mathfunctions = new AstroMathFunctions();

            Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");

            Console.ReadLine();
        }
    }
}
