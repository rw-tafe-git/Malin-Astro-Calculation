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

            Console.WriteLine(mathfunctions.StarVelocity(500.1f, 500));

            //Console.WriteLine(mathfunctions.StarDistance(0.547f, 1.83f));

            //Console.WriteLine(mathfunctions.StarVelocity(500.1f, 500));

            //Console.WriteLine(mathfunctions.StarVelocity(500.1f, 500));

            Console.ReadLine();
        }
    }
}
