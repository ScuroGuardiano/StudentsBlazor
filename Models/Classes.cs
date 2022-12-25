using System.ComponentModel.DataAnnotations;

namespace TeacherPro.Models;

public class Classes
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Range(0, 6)]
    public uint? DayOfWeek { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public ICollection<Student> Students { get; set; } = null!;
}