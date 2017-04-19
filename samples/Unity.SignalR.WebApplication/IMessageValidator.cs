namespace Unity.SignalR.WebApplication
{
    public interface IMessageValidator
    {
        void Validate(string message);
    }
}