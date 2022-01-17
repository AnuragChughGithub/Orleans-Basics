using OrleansBasics.Common.Config;
using Microsoft.Extensions.Options;
using Orleans;

namespace OrleansBasics.Client.ExtensionMethods;

public static class IClientBuilderExtensions
{
    /// <summary>
    /// Configures clustering for the Orleans Client based on
    /// the Orleans environment.
    /// </summary>
    /// <param name="builder">The client builder.</param>
    /// <param name="orleansConfig">The Orleans configuration.</param>
    /// <param name="environmentName">The environment.</param>
    public static IClientBuilder ConfigureClustering(
        this IClientBuilder builder,
        OrleansConfig orleansConfig,
        string environmentName
    )
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.UseLocalhostClustering();

        //            switch (environmentName.ToLower())
        //            {
        //                case "dev":
        //                    builder.UseLocalhostClustering();
        //                    break;
        //                default:
        //                    var orleansConfig = orleansConfigOptions.Value;
        //                    List<IPEndPoint> nodes = new List<IPEndPoint>();
        //                    foreach (var node in orleansConfig.NodeIpAddresses)
        //                    {
        //                        nodes.Add(new IPEndPoint(IPAddress.Parse(node), orleansConfig.GatewayPort));
        //                    }
        //                    builder.UseStaticClustering(nodes.ToArray());
        //                    break;
        //            }

        return builder;
    }
}