using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using CRUD.Services;
using CRUD.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CRUD API with MySQL",
        Version = "v1",
        Description = "A simple CRUD API to manage users in MySQL database."
    });
});

builder.Services.AddSingleton<DatabaseConnection>(sp =>
    new DatabaseConnection("localhost", "CrudExample", "root", "rootpassword"));
builder.Services.AddScoped<UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRUD API V1");
    c.RoutePrefix = string.Empty; 
});


app.MapControllers();

app.Run();
