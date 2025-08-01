using Microsoft.AspNetCore.SignalR;

namespace Web.Hubs
{
    public class Game : Hub
    {
        public Task Joined(string playerName)
        {
            return Clients.All.SendAsync("PlayerJoined", playerName);
        }
    }
}
