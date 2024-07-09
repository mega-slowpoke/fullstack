namespace Main;

public class Department : IDepartmentService
{
    public HashSet<int> Courses { get; set; } = new HashSet<int>();
    
    public int Head { get; set; }

    public decimal Budget { get; set; }
    
    public bool IsHead(int instructorId)
    {
        return instructorId == Head;
    }
    
    
    public bool AddCourse(int courseId)
    {
        if (!Courses.Contains(courseId))
        {
            Courses.Add(courseId);
            return true;
        }

        return false;
    }

    public bool RemoveStudent(int courseId)
    {
        if (Courses.Contains(courseId))
        {
            Courses.Remove(courseId);
            return true;
        }
        return false;
    }
}