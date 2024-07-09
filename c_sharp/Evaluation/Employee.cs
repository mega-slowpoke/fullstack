namespace Evaluation;

public class Employee
{
    public int Id { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public string Name { get; set; }

    public Employee(int id, string department, decimal salary, string name)
    {
        Id = id;
        Department = department;
        Salary = salary;
        Name = name;
    }
    
    public override string ToString()
    {
        return $"ID: {Id} \t Name: {Name} \t Department: {Department} \t Salary: {Salary}";
    }
}