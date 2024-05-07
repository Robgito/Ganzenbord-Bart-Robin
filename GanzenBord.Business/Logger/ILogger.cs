namespace Ganzenbord.Business.Logger
{
    public interface ILogger
    {
        string PrintMessage(string message);
        string ReadInput();
    }
}