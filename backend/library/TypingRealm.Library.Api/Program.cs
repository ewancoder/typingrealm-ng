using System;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/now", () => new
{
    Date = DateTime.UtcNow
});

await app.RunAsync();
