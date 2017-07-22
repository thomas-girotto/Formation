using System;

namespace Exercice1
{
    public class Sensor
    {
        const double Offset = 16;

        public double PopNextPressurePsiValue()
        {
            var basicRandomNumbersGenerator = new Random();
            return Offset + 6 * basicRandomNumbersGenerator.NextDouble();
        }
    }
}
