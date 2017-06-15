using System;

namespace Exercice1
{
    public class SensorAdapter : ISensorAdapter
    {
        private Sensor _sensor = new Sensor();

        public double PopNextPressurePsiValue()
        {
            return _sensor.PopNextPressurePsiValue();
        }
    }
}
