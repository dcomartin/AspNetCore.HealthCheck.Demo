using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AspNetCore.HealthCheck.Demo
{
    public class DbContextHealthCheck : IHealthCheck
    {
        private readonly MyDbContext _dbContext;

        public DbContextHealthCheck(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            return await _dbContext.Database.CanConnectAsync(cancellationToken)
                ? HealthCheckResult.Healthy()
                : HealthCheckResult.Degraded();
        }
    }
}