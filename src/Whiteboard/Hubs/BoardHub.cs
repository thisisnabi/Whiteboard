using Microsoft.AspNetCore.SignalR;

namespace Whiteboard.Hubs;

public class BoardHub : Hub
{
    public async Task SendDrawAction(int x1, int y1, int x2, int y2)
    {
        await Clients.Others.SendAsync("GetDrawAction", x1, y1, x2, y2);
    }
 
}
