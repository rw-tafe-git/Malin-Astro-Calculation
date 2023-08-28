using AstroMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AstroServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class ServerLMP : IAstroContract
    {
        AstroMathFunctions mathfunctions = new AstroMathFunctions();

        public double StarVelocity(double observedWaveLength, double restWaveLength)
        {
            return StarVelocity(observedWaveLength, restWaveLength);
        }
        public double StarDistance(double arcsecondsAngle)
        {
            return StarDistance(arcsecondsAngle);
        }
        public double TemperatureInKelvin(double celsius)
        {
            return TemperatureInKelvin(celsius);
        }
        public double EventHorizon(double blackHoleMass)
        {
            return EventHorizon(blackHoleMass);
        }
    }
}
