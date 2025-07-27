var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(policy =>
    policy.SetIsOriginAllowed(origin =>
        new Uri(origin).Host == "localhost")
    .AllowAnyHeader()
    .AllowAnyMethod());

app.UseStaticFiles();
app.MapControllers();


app.Run();




