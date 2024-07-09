namespace Main;

public interface IDepartmentService
{
    bool IsHead(int instructorId);
    bool AddCourse(int courseId);
    bool RemoveStudent(int courseId);
}