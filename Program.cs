using Microsoft.EntityFrameworkCore;
using SmartFood.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CosmosDb
var cosmosSection = builder.Configuration.GetSection("CosmosDb");
string accountEndpoint = cosmosSection["AccountEndpoint"];
string accountKey = cosmosSection["AccountKey"];
string database = cosmosSection["Database"];

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseCosmos(accountEndpoint, accountKey, database));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
