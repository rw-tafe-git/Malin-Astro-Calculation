using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AstroMathFunctions mathfunctions = new AstroMathFunctions();

            // Example test functions
            Console.WriteLine(mathfunctions.StarVelocity(500.1f, 500));

            Console.WriteLine(mathfunctions.StarDistance(0.547f));

            Console.WriteLine(mathfunctions.TemperatureInKelvin(27));

            Console.WriteLine(mathfunctions.EventHorizon(8.2 * Math.Pow(10, 36)));

            Console.ReadLine();
        }
    }
}
