using Microsoft.AspNet.SignalR;

namespace Unity.SignalR.WebApplication
{
    public class ChatHub : Hub
    {
        private readonly IMessageValidator messageValidator;

        public ChatHub(IMessageValidator messageValidator)
        {
            this.messageValidator = messageValidator;
        }

        public void Send(string name, string message)
        {
            messageValidator.Validate(message);

            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}