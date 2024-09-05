using Whiteboard.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR(); 

builder.Services.AddRazorPages();

var app = builder.Build();
 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapHub<BoardHub>("board");

app.Run();
