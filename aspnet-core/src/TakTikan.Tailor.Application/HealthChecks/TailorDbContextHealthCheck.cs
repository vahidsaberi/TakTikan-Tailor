using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TakTikan.Tailor.EntityFrameworkCore;

namespace TakTikan.Tailor.HealthChecks
{
    public class TailorDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public TailorDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("TailorDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("TailorDbContext could not connect to database"));
        }
    }
}
