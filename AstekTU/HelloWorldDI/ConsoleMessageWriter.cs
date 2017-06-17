using System;

namespace HelloWorldDI
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
