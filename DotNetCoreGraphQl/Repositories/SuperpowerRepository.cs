using DotNetCoreGraphQl.Data;
using DotNetCoreGraphQl.Interfaces;

namespace DotNetCoreGraphQl.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
