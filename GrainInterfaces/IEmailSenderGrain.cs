using Orleans;

namespace OrleansBasics.GrainInterfaces
{
    public interface IEmailSenderGrain : IGrainWithGuidKey, IGrainInterfaceMarker
    {
        Task SendEmail(string from, string[] to, string subject, string body);
    }
}
