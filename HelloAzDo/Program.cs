var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Text("Welcome to Azure DevOps Pipelines!", "text/plain"));

app.Run();
