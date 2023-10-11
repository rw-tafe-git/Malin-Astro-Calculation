using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstroMathFunctions
    {
		// Student Riley, id 30002737, Date: 23/08/2023
        // Assessment Task 2

        /// <summary>
        /// Math functions dll
        /// </summary>
		
        public double StarVelocity(double observedWaveLength, double restWaveLength)
        {
            double c = 2.99792458 * Math.Pow(10, 8);
            double waveLengthChange = observedWaveLength - restWaveLength;
			double result = Math.Round(c * (waveLengthChange / restWaveLength), 4);

            return result;
        }
        public double StarDistance(double arcsecondsAngle)
        {
            double result = 1 / arcsecondsAngle;

            return result;
        }
        public double TemperatureInKelvin(double celsius)
        {
            double result = celsius + 273;

            return result;
        }
        public double EventHorizon(double blackHoleMass)
        {
            double c = (2.99792458 * Math.Pow(10, 8));
			double lightSpeedSquared = Math.Pow(c, 2.0);
			double gravity = 6.674 * Math.Pow(10, -11);
			double calcl = (2 * gravity * blackHoleMass);
			double result = calcl / lightSpeedSquared;
			
			return result;
        }
    }
}
