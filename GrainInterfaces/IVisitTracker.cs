using Orleans;

namespace OrleansBasics.GrainInterfaces
{
    public interface IVisitTracker : IGrainWithStringKey, IGrainInterfaceMarker
    {
        Task<int> GetNumberOfVisits();
        Task Visit();
    }
}
