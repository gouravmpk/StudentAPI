using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    // public string CourseList { get; set; }
    
    // public virtual Courses Courses { get; set; }
}