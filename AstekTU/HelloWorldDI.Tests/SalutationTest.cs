using NFluent;
using NUnit.Framework;

namespace HelloWorldDI
{
    public class SalutationTest
    {
        [Test]
        public void Should_Write_HelloWorld()
        {
            // Given
            var spy = new MessageWriterSpy();
            var salutation = new Salutation(spy);

            // When
            salutation.Salute();

            // Then
            Check.That(spy.TextWritten).IsEqualTo("Hello World");
        }
    }
}
