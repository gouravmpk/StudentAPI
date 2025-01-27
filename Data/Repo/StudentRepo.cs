using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Repo;

public class StudentRepo:IStudentRepo
{
    private readonly AppDbContext _context;

  public  StudentRepo(AppDbContext context)
    {
        _context = context;
    }

    public List<Student> GetStudents()
    {
        var stud= _context.Students.ToList();
        
        return stud;
    }

    public Student GetStudent(int id)
    {
        return _context.Students.FirstOrDefault(x=>x.Id==id);
        
    }

    public Student AddStudent(Student student)
    {
        
        var s = new Student()
        {
            Name = student.Name,
            Email = student.Email,
            Phone = student.Phone, 
            
        };
        _context.Students.Add(s);
        _context.SaveChanges();
     
     
        return student;

    }

    public async  Task<Student> UpdateStudent(Student student)
    {
       var s= GetStudent(student.Id);
       if (s != null)
       {
           s.Name = student.Name;
           s.Email = student.Email;
           s.Phone = student.Phone;
       }
       await _context.SaveChangesAsync();
        return s;
    }

    public Task DeleteStudent(int id)
    {
        var s =GetStudent(id);
        if (s != null)
        {
            _context.Students.Remove(s);
        }
        return _context.SaveChangesAsync();
    }

    public void ValidateStudent(string Name, string password)
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}