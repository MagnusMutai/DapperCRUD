using Dapper;
using DapperCRUD.Models;
using System.Data.SqlClient;

namespace DapperCRUD.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly IConfiguration configuration;

        public VideoGameRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<List<VideoGame>> GetAllAsync()
        {
            using var connection = GetConnection();
            var videoGames = await connection.QueryAsync<VideoGame>("SELECT * FROM VIDEOGAMES");
        }

        private SqlConnection GetConnection() 
        {
            return new SqlConnection(
                configuration
                .GetConnectionString("DefaultConnection")
                );
        }
    }
}
