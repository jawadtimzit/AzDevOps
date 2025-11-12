var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Text ("Welcome To Azure DevOps Pipelines!", "text/plain"));

app.Run();
