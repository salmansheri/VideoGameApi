using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using VideoGameApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<VideoGameDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers()
.AddJsonOptions(options => 
{
    options.JsonSerializerOptions.ReferenceHandler  = System.Text.Json.Serialization.ReferenceHandler.Preserve; 
}
); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
