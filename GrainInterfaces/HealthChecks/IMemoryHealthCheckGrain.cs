using Microsoft.Extensions.Diagnostics.HealthChecks;
using Orleans;

namespace OrleansBasics.GrainInterfaces.HealthChecks
{
    public interface IMemoryHealthCheckGrain : IHealthCheck, IGrainWithGuidKey
    {

    }
}
