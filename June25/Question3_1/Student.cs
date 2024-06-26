namespace Main;

public class Student : Person, IStudentService
{
    public double GPA { get; set; }

    public Dictionary<ICourseService, char> CoursesAndGrades { get; set; } = new Dictionary<ICourseService, char>();
    
    public Student(int id, string name, int age) : base(id, name, age)
    {
    }

    public void EnrollCourse(ICourseService course)
    {
        course.AddStudent(Id);
        CoursesAndGrades.Add(course, 'I');
    }

    public double CalGPA()
    {
        int courseNum = 0;
        double totalGPA = 0;
        foreach (KeyValuePair<ICourseService, char> pair in CoursesAndGrades)
        {
            if (pair.Value != 'I')
            {
                totalGPA += 4.0 - (pair.Value - 'A');
            }
        }
        GPA = totalGPA / courseNum;
        return GPA;
    }
}