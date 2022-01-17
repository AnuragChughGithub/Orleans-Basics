using OrleansBasics.GrainInterfaces.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Orleans;

namespace OrleansBasics.Silo.HealthChecks;

public class BasicOrleansHealthCheck : OrleansHealthCheckBase
{
    public BasicOrleansHealthCheck(IClusterClient client) : base(client)
    {

    }

    protected override async Task<HealthCheckResult> CheckHealthGrainAsync(HealthCheckContext context, CancellationToken cancellationToken)
    {
        try
        {
            return await _client.GetGrain<IBasicHealthCheckGrain>(Guid.Empty)
                .CheckHealthAsync(context, cancellationToken);
        }
        catch (Exception e)
        {
            return HealthCheckResult.Unhealthy($"Health check failed.", e);
        }
    }
}
