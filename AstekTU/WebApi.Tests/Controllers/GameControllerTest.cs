using Microsoft.Owin;
using NFluent;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using WebApi.Controllers;
using WebApi.SsoLib;

namespace WebApi.Tests.Controllers
{
    public class GameControllerTest
    {
        [Test]
        public async Task Should_return_NotFound_When_gameId_does_not_exist()
        {
            // Given
            var request = new HttpRequestMessage();
            var owinContext = Substitute.For<IOwinContext>();
            owinContext.Get<UserInfo>("user_informations").Returns(new UserInfo());
            request.SetOwinContext(owinContext);
            var controller = new GameController();
            controller.Request = request;

            // When
            var result = controller.Get(1);

            // Then
            var httpResponse = await result.ExecuteAsync(CancellationToken.None);
            Check.That(httpResponse.StatusCode).IsEqualTo(HttpStatusCode.NotFound);
        }
    }
}
