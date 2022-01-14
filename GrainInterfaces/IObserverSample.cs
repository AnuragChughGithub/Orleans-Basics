using Orleans;

namespace GrainInterfaces
{
    public interface IObserverSample : IGrainObserver
    {
        void ReceiveMessage(string message);
    }
}
