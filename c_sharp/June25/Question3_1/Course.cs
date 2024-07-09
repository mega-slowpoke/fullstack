namespace Main;

public class Course: ICourseService
{
    public int CourseId { get; set; }
    public HashSet<int> StudentIds { get; } = new HashSet<int>();

    public bool AddStudent(int studentId)
    {
        if (!StudentIds.Contains(studentId))
        {
            StudentIds.Add(studentId);
            return true;
        }

        return false;
    }

    public bool RemoveStudent(int studentId)
    {
        if (StudentIds.Contains(studentId))
        {
            StudentIds.Remove(studentId);
            return true;
        }
        return false;
    }
}