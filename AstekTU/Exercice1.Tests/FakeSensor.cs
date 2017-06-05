using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Tests
{
    public class FakeSensor : ISensor
    {
        private double _value = 18;

        public void SetTheNextPressurePsiValue(double value)
        {
            _value = value;
        }
        public double PopNextPressurePsiValue()
        {
            return _value;
        }
    }
}
