using Orleans;

namespace GrainInterfaces
{
    public interface IEverythingIsOkGrain : IGrainWithStringKey, IRemindable
    {
        Task Start();
        Task Stop();
    }
}
