using Orleans;

namespace OrleansBasics.GrainInterfaces
{
    public interface IObservableManager : IGrainWithIntegerKey, IGrainInterfaceMarker
    {
        Task Subscribe(IObserverSample observer);
        Task Unsubscribe(IObserverSample observer);
        Task SendMessageToObservers(string message);
    }
}
