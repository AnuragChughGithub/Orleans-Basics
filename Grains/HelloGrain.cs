using Orleans;
using OrleansBasics.GrainInterfaces;

namespace OrleansBasics.Grains
{
    public class HelloGrain : Grain, IHelloGrain, IGrainMarker
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"Hello from grain {this.GetGrainIdentity()}, {name}!");
        }
    }
}