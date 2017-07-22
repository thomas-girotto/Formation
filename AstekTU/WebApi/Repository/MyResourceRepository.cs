using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{

    public class MyResourceRepository : IMyResourceRepository
    {
        public Task<MyResource> GetByIdAsync(int id)
        {
            // let's say game 1 doesn't exists in DB
            if (id == 1)
                return Task.FromResult<MyResource>(null);
            return Task.FromResult(new MyResource
            {
                Id = id
            });
        }
    }
}