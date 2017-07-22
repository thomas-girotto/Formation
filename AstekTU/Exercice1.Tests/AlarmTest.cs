using NUnit.Framework;

namespace Exercice1.Tests
{
    public class AlarmTest
    {
        private Alarm _alarm;

        [SetUp]
        public void Setup()
        {
            _alarm = new Alarm();
        }

        [Test]
        public void Should_raise_an_alarm_When_pressure_is_lower_than_17()
        {
        }
    }
}
