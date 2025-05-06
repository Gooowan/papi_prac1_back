using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using papi_prac1_back;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<MessageManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.MapGet("/", () => "API is running");
app.UseCors("AllowAll");

app.MapControllers();

app.Run();