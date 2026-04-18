using Microsoft.EntityFrameworkCore;
using VideoGameApi.Data;
using VideoGameApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IVideoGameCharacterService, VideoGameCharacterService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Map the native OpenAPI endpoint (usually /openapi/v1.json)
    app.MapOpenApi();

    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
