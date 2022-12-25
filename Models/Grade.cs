using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherPro.Models;

public enum GradeType {
    /// <summary>
    ///     Ocena 2, 2.5, 3, 3.5, 4, 4.5, 5
    /// </summary>
    GradeScale,
    /// <summary>
    /// Punkty za sprawdzian
    /// </summary>
    Points
}

public class Grade
{
    public int Id { get; set; }

    public double Value { get; set; }

    public GradeType GradeType { get; set; }

    public Student Student { get; set; } = null!;

    public Classes Classes { get; set; } = null!;
}