using Orleans;

namespace OrleansBasics.GrainInterfaces
{
    public interface IObserverSample : IGrainObserver
    {
        void ReceiveMessage(string message);
    }
}
