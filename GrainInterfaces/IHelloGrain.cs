
namespace OrleansBasics.GrainInterfaces
{
    //Interface that defines an Orleans grain and its key type

    public interface IHelloGrain : Orleans.IGrainWithGuidKey
    {
        Task<string> SayHello(string greeting);
    }
}