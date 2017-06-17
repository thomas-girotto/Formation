using System;

namespace HelloWorldDI
{
    public class MessageWriterSpy : IMessageWriter
    {
        public string TextWritten { get; set; }

        public void Write(string text)
        {
            TextWritten = text;
        }
    }
}
