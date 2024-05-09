namespace Ganzenbord.Business.Logger
{
    public interface ILogger
    {
        void ClearConsole();

        string PrintMessage(string message);

        string ReadInput();

        void WriteEmptyLine();
    }
}