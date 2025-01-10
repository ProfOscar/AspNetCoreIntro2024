using AspNetCoreIntro2024.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUsersService, UsersService>();

//builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
