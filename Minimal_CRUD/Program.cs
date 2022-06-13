using Microsoft.EntityFrameworkCore;
using Minimal_CRUD;
using Minimal_CRUD.MinimalAPI_Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("TestDB"));
builder.Services.AddScoped<IArticleService, ArticleService>();
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

// Minimal API Map end points//

app.MapArticleRoutes();

// END //

app.Run();

