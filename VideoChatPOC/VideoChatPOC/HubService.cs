using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;

namespace VideoChatPOC
{
    public class HubService : Hub
    {
        public async Task Send(string message)
        {
            await Clients.Others.SendAsync("Signaling", message);
        }
    }
}
