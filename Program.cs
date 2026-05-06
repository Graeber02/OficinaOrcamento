using Oficina.Api.Application.Services;
using Oficina.Api.Domain.Interfaces;
using Oficina.Api.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IOrcamentoService, OrcamentoService>();
builder.Services.AddSingleton<IOrcamentoRepository, OrcamentoRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();