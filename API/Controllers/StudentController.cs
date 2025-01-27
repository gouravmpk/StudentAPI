using ClassLibrary1;
using ClassLibrary1.Repo;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private readonly IStudentRepo _student;
    public StudentController(IStudentRepo student)
    {
        _student = student; 
    }

    [HttpGet]
    public async Task<List<Student>> GetAllStudent()
    {
        return  _student.GetStudents();
    }

    [HttpGet("id")]
    public async Task<Student> GetStudent(int id)
    {
        return _student.GetStudent(id);
    }

    [HttpPost]
    public async Task<Student> AddStudent(Student student)
    {
       return _student.AddStudent(student);
    }

    [HttpPut("id")]
    public async Task<Student> UpdateStudent(Student student)
    {
        return await _student.UpdateStudent(student);
    }

    [HttpDelete]
    public async Task DeleteStudent(int id)
    {
        await _student.DeleteStudent(id);
         
    }
}