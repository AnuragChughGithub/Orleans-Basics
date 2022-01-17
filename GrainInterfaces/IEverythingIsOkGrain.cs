using Orleans;

namespace OrleansBasics.GrainInterfaces
{
    public interface IEverythingIsOkGrain : IGrainWithStringKey, IRemindable
    {
        Task Start();
        Task Stop();
    }
}
