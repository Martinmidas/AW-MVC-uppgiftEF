using AW_MVC_uppgift_3.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<DataService>(); // Registrera f�r DI - ny instans varje g�ng
builder.Services.AddSingleton<DataService>(); // Registrera f�r DI - samma instans varje g�ng
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());

app.Run();
