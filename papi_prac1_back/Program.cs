using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using papi_prac1_back;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<MessageManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "API is running");

app.MapControllers();

app.Run();