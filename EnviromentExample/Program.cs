var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if(app.Environment.IsDevelopment() || app.Environment.IsStaging()) // look in to properties/launchSetting.json
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();

// run production: dotnet run --no-launch-profile
// set other env : $Env:ASPNETCORE_ENVIRONMENT="Staging" ,  dotnet run --no-launch-profile