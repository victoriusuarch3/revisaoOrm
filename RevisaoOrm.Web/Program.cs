using Microsoft.EntityFrameworkCore;
using RevisaoOrm.Lib.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Add services to the container.
builder.Services.AddDbContext<RevisaoOrmContext>
(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("revisaoOrm")).UseSnakeCaseNamingConvention());


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
