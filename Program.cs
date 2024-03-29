using webApiAutores;

var builder = WebApplication.CreateBuilder(args);



var startup = new startUp(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app, app.Environment);
app.Run();