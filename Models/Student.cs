using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherPro.Models;

public class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    [NotMapped]
    public string FullName => FirstName + " " + LastName;

    public string? StudentNumber { get; set; }

    public ICollection<Classes> Classes { get; set; } = null!;

    public ICollection<Grade> Grades { get; set; } = null!;
}