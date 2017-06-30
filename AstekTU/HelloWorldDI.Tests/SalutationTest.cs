using NFluent;
using NSubstitute;
using NUnit.Framework;

namespace HelloWorldDI
{
    public class SalutationTest
    {
        [Test]
        public void Should_Write_HelloWorld_with_custom_spy()
        {
            // Given
            var spy = new MessageWriterSpy();
            var salutation = new Salutation(spy);

            // When
            salutation.Salute();

            // Then
            Check.That(spy.TextWritten).IsEqualTo("Hello World");
        }
        
        [Test]
        public void Should_Write_HelloWorld_With_mock_library()
        {
            // Given
            var fakeMessageWriter = Substitute.For<IMessageWriter>();
            string writtenText = string.Empty;
            fakeMessageWriter
                .When(x => x.Write(Arg.Any<string>()))
                .Do(args => writtenText = args.Arg<string>());
            var salutation = new Salutation(fakeMessageWriter);

            // When
            salutation.Salute();

            // Then
            Check.That(writtenText).IsEqualTo("Hello World");
        }
    }
}
