using Microsoft.AspNetCore.SignalR;

namespace Whiteboard.Hubs;

public record StrokeDto(float X1, float Y1, float X2, float Y2, float Thickness, string Color);


public class BoardHub : Hub
{
    public async Task DrawingAsync(int x1, int y1, int x2, int y2)
    {
        await Clients.Others
            .SendAsync("OnDrawingAsync", x1, y1, x2, y2);
    }

    public async Task DrawAsync(StrokeDto stroke)
    {
        // broadcast to everyone except sender
        await Clients.Others.SendAsync("draw", stroke);
    }
}
