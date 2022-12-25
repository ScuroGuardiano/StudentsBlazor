using Microsoft.EntityFrameworkCore;
using TeacherPro.Models;

namespace TeacherPro.Data;

public class TeacherProContext : DbContext
{
    public DbSet<Classes> Classes { get; set; } = null!;

    public DbSet<Grade> Grades { get; set; } = null!;

    public DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=data.db");
    }
}