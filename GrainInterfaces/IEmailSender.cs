namespace GrainInterfaces
{
    public interface IBasicHealthCheckGrain
    {
        Task SendEmailAsync(string from, string[] to, string subject, string body);
    }
}
