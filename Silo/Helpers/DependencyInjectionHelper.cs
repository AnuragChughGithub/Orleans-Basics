using OrleansBasics.GrainInterfaces;
using OrleansBasics.GrainInterfaces.HealthChecks;
using OrleansBasics.Grains;
using OrleansBasics.Grains.HealthChecks;
using Microsoft.Extensions.DependencyInjection;

namespace OrleansBasics.Silo.Helpers;

/// <summary>
/// Dependency Injection helper class
/// </summary>
public static class DependencyInjectionHelper
{
    /// <summary>
    /// Register concretions for DI.
    /// </summary>
    /// <param name="serviceCollection">The service collection in which to register thingers.</param>
    public static void IocContainerRegistration(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IEmailSender, FakeEmailSender>();
    }
}
