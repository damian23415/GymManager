using GymManager.Application;
using GymManager.Application.Common.Interfaces;
using GymManager.Infrastructure;
using GymManager.UI.Extensions;
using GymManager.UI.Middlewares;
using NLog.Web;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Information);
builder.Logging.AddNLogWeb();

builder.Services.AddCulture();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.DefineViewLocation(builder.Configuration);

builder.Services.AddControllersWithViews();
builder.Services.AddAplication();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    app.UseInfrastructure(
        scope.ServiceProvider.GetRequiredService<IApplicationDbContext>(),
        app.Services.GetService<IAppSettingsService>(),
        app.Services.GetService<IEmail>());
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

var logger = app.Services.GetService<ILogger<Program>>();

if (app.Environment.IsDevelopment())
{
    logger.LogInformation("DEVELOPMENT MODE!!!");
}
else
{
    logger.LogInformation("PRODUCTION MODE!!!");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
