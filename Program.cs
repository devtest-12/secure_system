using Scoops2GoAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<AuthService>();
builder.Services.AddSingleton<OrderService>();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

