using Microsoft.EntityFrameworkCore;

namespace Rieltor.Data
{
    public class DataEFContext : DbContext
    {
        public DataEFContext(DbContextOptions<DataEFContext> options)
           : base(options) { }
    }
}
