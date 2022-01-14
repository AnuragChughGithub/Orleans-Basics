using Microsoft.Extensions.Diagnostics.HealthChecks;
using Orleans;

namespace GrainInterfaces.HealthChecks
{
    public interface IMemoryHealthCheckGrain : IHealthCheck, IGrainWithGuidKey
    {

    }
}
