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

            Console.WriteLine(mathfunctions.StarVelocity(0, 0));
            Console.ReadLine();
        }
    }
}
