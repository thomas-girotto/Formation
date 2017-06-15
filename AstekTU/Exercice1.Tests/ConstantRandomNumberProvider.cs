using Exercice1.Utils;

namespace Exercice1.Tests
{
    public class ConstantRandomNumberProvider : RandomNumberProvider
    {
        private double _theNextDoubleValue;

        public ConstantRandomNumberProvider(double theNextDoubleValue)
        {
            _theNextDoubleValue = theNextDoubleValue;
        }
        public override double NextDouble()
        {
            return _theNextDoubleValue;
        }
    }
}
