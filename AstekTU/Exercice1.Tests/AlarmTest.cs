using NFluent;
using NSubstitute;
using NUnit.Framework;

namespace Exercice1.Tests
{
    public class AlarmTest
    {
        private Alarm _alarm;
        private ISensorAdapter _fakeSensor = Substitute.For<ISensorAdapter>();

        [SetUp]
        public void Setup()
        {
            _alarm = new Alarm(_fakeSensor);
        }

        [Test]
        public void Should_raise_an_alarm_When_pressure_is_lower_than_17()
        {
            // Given
            _fakeSensor.PopNextPressurePsiValue().Returns(16);
            
            // When
            _alarm.Check();

            // Then
            Check.That(_alarm.AlarmOn).IsTrue();
        }

        [TestCase(17)]
        [TestCase(18)]
        [TestCase(19)]
        [TestCase(20)]
        [TestCase(21)]
        public void Should_not_raise_an_alarm_When_pressure_is_between_17_and_21(double givenPressure)
        {
            // Given
            _fakeSensor.PopNextPressurePsiValue().Returns(givenPressure);

            // When
            _alarm.Check();

            // Then
            Check.That(_alarm.AlarmOn).IsFalse();
        }

        [Test]
        public void Should_raise_an_alarm_When_pressure_is_greater_than_21()
        {
            // Given
            _fakeSensor.PopNextPressurePsiValue().Returns(22);

            // When
            _alarm.Check();

            // Then
            Check.That(_alarm.AlarmOn).IsTrue();
        }
    }
}
