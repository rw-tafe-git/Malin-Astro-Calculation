using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstroMathFunctions
    {
        public double StarVelocity(double observedWaveLength, double restWaveLength)
        {
            double changeInWaveLength =  observedWaveLength - restWaveLength;
            double speedOfLight = 2.99792458;

            return 0;
        }
        public double StarDistance(double arcsecondsAngle)
        {
            double parallaxAngle = 0;
            double distance = 1 / parallaxAngle;

            return distance;
        }
        public double TemperatureInKelvin(double celsius)
        {
            double kelvin = celsius + 273;

            return kelvin;
        }
        public double EventHorizon(double blackHoleMass)
        {
            double gravityConstant = 0;
            double speedOfLight = 0;

            return 0;
        }
    }
}
