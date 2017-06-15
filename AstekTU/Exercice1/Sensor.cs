using Exercice1.Utils;
using System;

namespace Exercice1
{
    public class Sensor : ISensor
    {
        const double Offset = 16;

        public double PopNextPressurePsiValue()
        {
            double pressureTelemetryValue;
            SamplePressure(out pressureTelemetryValue);

            return Offset + pressureTelemetryValue;
        }

        private static void SamplePressure(out double pressureTelemetryValue)
        {
            pressureTelemetryValue = 6 * RandomNumberProvider.Current.NextDouble() 
                * RandomNumberProvider.Current.NextDouble();
        }
    }
}
