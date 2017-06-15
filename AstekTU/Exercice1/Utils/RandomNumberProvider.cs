using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Utils
{
    public abstract class RandomNumberProvider
    {
        public static RandomNumberProvider Current { get; private set; }

        static RandomNumberProvider()
        {
            Current = new DefaultRandomNumberProvider();
        }

        public abstract double NextDouble();

        public static void SetACustomRandomProvider(RandomNumberProvider provider)
        {
            Current = provider;
        }
    }
}
