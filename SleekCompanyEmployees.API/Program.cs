using SleekCompanyEmployees.API.Extensions;

var app = WebApplication.CreateBuilder(args)
    .RegisterServices()
    .Build();

app.SetupMiddleware()
    .Run();