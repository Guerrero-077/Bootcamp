using Microsoft.AspNetCore.SignalR;

namespace Web.Hubs
{
    public class GameJoin : Hub
    {
        public Task Joined(string playerName)
        {
            return Clients.All.SendAsync("PlayerJoined", playerName);
        }
    }
}
