using NUnit.Framework;
using System.Threading.Tasks;
using Mock4Net.Core;
using WebApi.Repository;
using NFluent;

namespace WebApi.Tests.Repository
{
    public class MyResourceHttpRepositoryTest
    {
        private FluentMockServer _server;
        private MyResourceHttpRepository _repo = new MyResourceHttpRepository();
        
        [SetUp]
        public void Setup()
        {
            _server = FluentMockServer.Start(5800);
        }

        [Test]
        public void Should_get_the_remote_resource_and_translate_it()
        {
            
        }
    }
}
