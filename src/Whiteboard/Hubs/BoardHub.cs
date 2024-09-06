using Microsoft.AspNetCore.SignalR;

namespace Whiteboard.Hubs;

public class BoardHub : Hub
{
    public async Task DrawingAsync(int x1, int y1, int x2, int y2)
    {
        await Clients.Others
            .SendAsync("OnDrawingAsync", x1, y1, x2, y2);
    }
}
