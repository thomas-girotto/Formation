using System;

namespace Exercice1.Utils
{
    public class DefaultRandomNumberProvider : RandomNumberProvider
    {
        private Random _basicRandomNumbersGenerator;

        public DefaultRandomNumberProvider()
        {
            _basicRandomNumbersGenerator = new Random();
        }
        public override double NextDouble() => _basicRandomNumbersGenerator.NextDouble();
    }
}
