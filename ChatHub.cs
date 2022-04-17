using PremParikh_Chat.Server.Hubs;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PremParikh_Chat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}