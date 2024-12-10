using middleware.Middlewares;
using System.Diagnostics;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/*
app.Map("/map1", HandleMapTest1);

app.Map("/map2", HandleMapTest2);


app.Use(async (context, next) =>
{
    Debug.Write("Before Invoke from 1st app.Use()\n");
    await next();
    Debug.Write("After Invoke from 1st app.Use()\n");
});

app.Use(async (context, next) =>
{
    Debug.Write("Before Invoke from 2nd app.Use()\n");
    await next();
     Debug.Write("After Invoke from 2nd app.Use()\n");
});

app.Run(async (context) =>
{
    Debug.Write("Hello from 1st app.Run()\n");
});

// the following will never be executed
app.Run(async (context) =>
{
    Debug.Write("Hello from 2nd app.Run()\n");
});*/


app.Userc();


app.Run();
