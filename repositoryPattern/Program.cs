﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using repositoryPattern.Data.EFCore;

var builder = WebApplication.CreateBuilder(args);
var serverVersion = new MySqlServerVersion(new Version(8, 0));
builder.Services.AddDbContext<repositoryPatternContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("repositoryPatternContext"), serverVersion));

// Add services to the container.
builder.Services.AddScoped<EfCoreMovieRepository>();
builder.Services.AddScoped<EfCoreStarRepository>();

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
