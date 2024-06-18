using Microsoft.AspNetCore.SignalR;

namespace Wurqout.Hubs
{
    public class WorkoutHub : Hub
    {

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendData(string groupName, string data)
        {
            await Clients.Group(groupName).SendAsync("ReceiveData", data);
        }

    }
}
