using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDI
{
    public class Salutation
    {
        private IMessageWriter _writer;

        public Salutation(IMessageWriter writer)
        {
            _writer = writer;
        }

        public void Salute()
        {
            _writer.Write("Hello World");
        }
    }
}
