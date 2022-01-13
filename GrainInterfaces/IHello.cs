
namespace OrleansBasics
{
    //Interface that defines an Orleans grain and its key type

    public interface IHello : Orleans.IGrainWithGuidKey
    {
        Task<string> SayHello(string greeting);
    }
}