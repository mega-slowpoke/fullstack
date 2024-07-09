namespace Main;

public class Instructor : Person, IInstructorService
{
    public IInstructorService Department { get; set; }
        
    public DateTime JoinDate { get; set; }
        
    public Instructor(int id, string name, int age, IInstructorService department, DateTime joinDate) : base(id, name, age)
    {
        Department = department;
        JoinDate = joinDate;
    }

    public override decimal CalculateTotalSalary()
    {
        decimal baseSalary = 10000;
        decimal experienceSalary = 300 * (DateTime.Today.Year - JoinDate.Year);
        return baseSalary + experienceSalary;
    }
}