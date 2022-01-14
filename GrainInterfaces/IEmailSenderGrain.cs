using Orleans;

namespace GrainInterfaces
{
    public interface IEmailSenderGrain : IGrainWithGuidKey, IGrainInterfaceMarker
    {
        Task SendEmail(string from, string[] to, string subject, string body);
    }
}
