using Exercice1.Utils;
using NFluent;
using NUnit.Framework;

namespace Exercice1.Tests
{
    public class SensorTest
    {
        [Test]
        public void Should_calculate_the_pressure_value_from_the_followinf_formula()
        {
            // Given
            var randomValue = 2;
            RandomNumberProvider.SetACustomRandomProvider(new ConstantRandomNumberProvider(randomValue));
            var sensor = new Sensor();
            // When
            var pressure = sensor.PopNextPressurePsiValue();
            // Then
            var expectedPressure = 16 + (6 * randomValue * randomValue);
            Check.That(pressure).IsEqualTo(expectedPressure);
        }
    }
}
