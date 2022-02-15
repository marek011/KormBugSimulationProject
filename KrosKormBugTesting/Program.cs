using Kros.KORM.Extensions.Asp;
using KrosKormBugTesting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddKorm(builder.Configuration)
    .UseDatabaseConfiguration(new DatabaseConfiguration())
    .AddKormMigrations()
    .Migrate();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
