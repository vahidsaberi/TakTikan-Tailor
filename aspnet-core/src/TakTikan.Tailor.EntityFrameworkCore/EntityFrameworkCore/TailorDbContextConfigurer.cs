using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TakTikan.Tailor.EntityFrameworkCore
{
    public static class TailorDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TailorDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TailorDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}