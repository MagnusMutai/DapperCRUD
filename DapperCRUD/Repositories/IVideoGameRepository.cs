using DapperCRUD.Models;

namespace DapperCRUD.Repositories
{
    public interface IVideoGameRepository
    {
        Task<List<VideoGame>> GetAllAsync();
    }
}
