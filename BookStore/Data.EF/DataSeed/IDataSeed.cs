using Microsoft.EntityFrameworkCore;

namespace Data.EF.DataSeed
{
    public interface IDataSeed
    {
        ModelBuilder Seed(ModelBuilder modelBuilder, string systemUser);
    }
}
