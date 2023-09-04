using AstroMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AstroServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWaveLength, double restWaveLength);

        [OperationContract]
        double StarDistance(double arcsecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celsius);

        [OperationContract]
        double EventHorizon(double blackHoleMass);
    }
}
