using AFP_Backend.Contexts;
using AFP_Backend.Modules.BiFilters.Contracts.IRepository;
using AFP_Backend.Modules.BiFilters.Models;
using AFP_Backend.Modules.Public.Repository;

namespace AFP_Backend.Modules.BiFilters.Repository;
public class BiFiltersRepository : GenericRepository<BiFilter>, IBiFilterRepository
{
    private readonly MaroonContext _dbContext;

    public BiFiltersRepository(MaroonContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }
}
