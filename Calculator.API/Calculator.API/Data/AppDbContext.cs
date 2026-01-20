// Web API Project -> Data -> AppDbContext.cs
using Calculator.API;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

// Убедитесь, что namespace соответствует вашему проекту (например, WpfHistoryApp2.Data)
// Если вы не создавали подпапку Data, то namespace будет просто WpfHistoryApp2
namespace WpfHistoryApp2.Data // Пример, замените на namespace вашего Web API проекта
{
    public class AppDbContext : DbContext
    {
        // Конструктор, который принимает опции для конфигурации DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet представляет таблицу в вашей базе данных.
        // Здесь мы говорим EF Core, что у нас будет таблица "Calculations",
        // которая будет хранить объекты типа Calculation.
        public DbSet<Calculation> Calculations { get; set; }

        // Если вы используете модель без поля Id, или Id не является первичным ключом,
        // или если нужно настроить связи между таблицами, это делается здесь.
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     // Например, modelBuilder.Entity<Calculation>().HasKey(c => c.SomeOtherId);
        // }
    }
}