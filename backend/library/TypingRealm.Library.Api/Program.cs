using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

// Applied on controllers, this attribute makes sure a number of API-related
// things happen, for example: 400 is thrown when random string is passed as a
// Guid input parameter
[assembly:ApiController]

var builder = WebApplication.CreateBuilder(args);

// Adds controllers to DI. Required by MapControllers.
builder.Services.AddControllers();

var app = builder.Build();

// Without this, controller classes are not being converted to endpoints (invisible).
// This also requires a call to AddControllers on services.
app.MapControllers();

app.MapGet("/now", () => new
{
    Date = DateTime.UtcNow
});

await app.RunAsync();
