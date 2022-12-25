using Microsoft.EntityFrameworkCore;
using TeacherPro.Data;
using TeacherPro.Models;

namespace TeacherPro.Services;

public class StudentService
{
    private TeacherProContext _context;

    public StudentService(TeacherProContext context)
    {
        _context = context;
    }

    public Task<int> CountStudents()
    {
        return _context.Students.CountAsync();
    }

    public Task<List<Student>> ListStudents(int offset = 0, int limit = 20)
    {
        var query = _context.Students.Skip(offset).Take(limit);
        return query.ToListAsync();
    }

    public IEnumerable<Student> GetStudents()
    {
        return _context.Students.AsQueryable();
    }

    public async Task<Student> AddStudent(string FirstName, string LastName, string? StudentNumber)
    {
        var student = new Student() {
            FirstName = FirstName,
            LastName = LastName,
            StudentNumber = StudentNumber
        };

        _context.Add(student);

        await _context.SaveChangesAsync();
        return student;
    }

    public async Task DeleteStudent(Student student)
    {
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
    }

    public Student CancelChanges(Student student)
    {
        var entry = _context.Students.Entry(student);
        if (entry.State == EntityState.Modified) {
            entry.CurrentValues.SetValues(entry.OriginalValues);
            entry.State = EntityState.Unchanged;
        }
        return student;
    }

    public async Task SaveChangesToDb()
    {
        await _context.SaveChangesAsync();
    }
}