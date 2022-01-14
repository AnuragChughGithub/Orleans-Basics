using Orleans;

namespace GrainInterfaces
{
    public interface IVisitTracker : IGrainWithStringKey, IGrainInterfaceMarker
    {
        Task<int> GetNumberOfVisits();
        Task Visit();
    }
}
