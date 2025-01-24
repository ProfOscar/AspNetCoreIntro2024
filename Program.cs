using AspNetCoreIntro2024.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IUsersService, UsersInMemoryService>();
builder.Services.AddSingleton<IUsersService, UsersSqlServerService>();

//builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// per utilizzare css, js, ecc... contenuti nella cartella wwwroot
app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
