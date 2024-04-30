using KiotaWithDependencyInjection.Kiota;
using KiotaWithDependencyInjection.Spotify;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Spotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register the Kiota handlers
// This only needs to be done once per application
builder.Services.AddKiotaHandlers();
// Register memory cache, because it's used to cache the access token for spotify
builder.Services.AddMemoryCache();

// Register the Spotify client
// The settings are loaded from configuration
// and requires the section `Spotify` to be present, with `ClientId` and `ClientSecret` keys.
builder.Services.AddSpotifyClient();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

