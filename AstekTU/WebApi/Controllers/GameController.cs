using System.Net.Http;
using System.Web.Http;
using WebApi.Services;
using WebApi.SsoLib;

namespace WebApi.Controllers
{
    public class GameController : ApiController
    {
        [HttpGet]
        [Route("api/game/{id}")]
        public IHttpActionResult Get(int id)
        {
            var gameRepo = new GameRepository();
            var user = Request.GetOwinContext().Get<UserInfo>("user_informations");

            var game = gameRepo.GetById(id, user.Name);
            if (game == null)
            {
                return NotFound();
            }
            if (game.UserName != user.Name)
            {
                return Unauthorized();
            }
            return Ok(game);
        }
    }
}
