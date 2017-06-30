using WebApi.Models;

namespace WebApi.Services
{
    public interface IGameRepository
    {
        Game GetById(int id, string userName);
    }

    public class GameRepository : IGameRepository
    {
        public Game GetById(int id, string userName)
        {
            // let's say game 1 doesn't exists in DB
            if (id == 1)
                return null;
            return new Game
            {
                Id = id,
                UserName = userName
            };
        }
    }
}