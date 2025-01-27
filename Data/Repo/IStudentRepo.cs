namespace ClassLibrary1.Repo;

public interface IStudentRepo
{
    public List<Student> GetStudents();
    public Student GetStudent(int id);
    public Student AddStudent(Student student);
    public Task<Student> UpdateStudent(Student student);
    public Task DeleteStudent(int id);
    public void ValidateStudent(string Name, string password);
    
} 