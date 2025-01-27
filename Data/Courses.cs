using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1;

public class Courses
{
    [Key]
    public int CoursesId { get; set; }
    public string CourseName { get; set; }

    public virtual Student student { get; set; }
}