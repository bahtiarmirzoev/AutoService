using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Подключение к базе данных (замените ConnectionString на вашу строку подключения)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ServiceDBContext>(options =>
    options.UseSqlServer(connectionString));

// Регистрация контроллеров и других сервисов
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настройка конвейера HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Подключение маршрутов для контроллеров
app.MapControllers();

app.Run();
