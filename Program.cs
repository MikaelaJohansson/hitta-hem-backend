var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(policy =>
    policy.WithOrigins(
        "https://hitta-hem-frontend-ftcfgmgkbbctdkgb.swedencentral-01.azurewebsites.net",
        "http://localhost:4200"
    )
    .AllowAnyHeader()
    .AllowAnyMethod());

app.UseStaticFiles();
app.MapControllers();

app.Run();





