using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrleansBasics.GrainInterfaces;
using OrleansBasics.Client.Helpers;
using Orleans;

namespace OrleansBasics.Client.OrleansFunctionExamples;

public class HelloGrain : IOrleansFunction
{
    public string Description => "Demonstrates the most basic Orleans function of 'Hello World'.";

    public async Task PerformFunction(IClusterClient clusterClient)
    {
        var grain = clusterClient.GetGrain<IHelloGrain>(Guid.NewGuid());
        Console.WriteLine("Hello! What should I call you?");
        var name = Console.ReadLine();

        Console.WriteLine(await grain.SayHello(name));

        ConsoleHelpers.ReturnToMenu();
    }
}
