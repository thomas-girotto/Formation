using System;

namespace HelloWorldDI
{
    class Program
    {
        public static void Main()
        {
            var salutation = new Salutation(new ConsoleMessageWriter());
            salutation.Salute();
            Console.ReadKey();
        }
    }
}
