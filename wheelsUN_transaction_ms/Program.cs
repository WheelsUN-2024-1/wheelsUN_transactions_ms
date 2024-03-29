using Microsoft.EntityFrameworkCore;
using wheelsUN_transaction_ms.Services;
using wheelsUN_transaction_ms.Utils;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.Data;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ISTransaction, STransaction>();
builder.Services.AddScoped<ISCreditCard, SCreditCard>();

builder.Services.AddScoped<MapTransaction>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<TransactionDTO>();
builder.Services.AddScoped<CreditCardDTO>();

var connectionString = builder.Configuration.GetConnectionString("ManualConnection");
builder.Services.AddDbContext<wheelsUN_transaction_context>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
