using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IMyResourceRepository
    {
        Task<MyResource> GetByIdAsync(int id);
    }
}