using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Repository
{
    public class MyResourceHttpRepository : IMyResourceRepository
    {
        public async Task<MyResource> GetByIdAsync(int id)
        {
            HttpResponseMessage response = null;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync($"http://localhost:5800/api/resource/{id}");
            }
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var stringContent = await response.Content.ReadAsStringAsync();
            var remote = JsonConvert.DeserializeObject<TheRemoteResource>(stringContent);
            return MapIntoOurDomainObject(remote);
        }

        private MyResource MapIntoOurDomainObject(TheRemoteResource remote)
        {
            return new MyResource
            {
                Id = remote.Id
            };
        }

        private class TheRemoteResource
        {
            public int Id { get; set; }
            public string SomeOtherPropertyThatImNotInterestedIn { get; set; }
        }
    }
}