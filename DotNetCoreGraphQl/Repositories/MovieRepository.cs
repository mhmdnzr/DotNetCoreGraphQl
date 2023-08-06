using DotNetCoreGraphQl.Data;
using DotNetCoreGraphQl.Interfaces;

namespace DotNetCoreGraphQl.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
