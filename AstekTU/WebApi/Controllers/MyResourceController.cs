using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Services;

namespace WebApi.Controllers
{
    public class MyResourceController : ApiController
    {
        [HttpGet]
        [Route("api/game/{id}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            var repository = new MyResourceRepository();
            var resource = await repository.GetByIdAsync(id);
            if (resource == null)
            {
                return NotFound();
            }
            return Ok(resource);
        }
    }
}
