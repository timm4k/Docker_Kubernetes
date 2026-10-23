var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { application = "MyApp.Api", status = "running" }));

app.Run();

public partial class Program
{
}
