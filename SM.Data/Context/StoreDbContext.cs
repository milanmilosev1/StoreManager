using Microsoft.EntityFrameworkCore;

namespace SM.Data.Context
{
    public class StoreDbContext(DbContextOptions options) : DbContext(options)
    {
    }
}
