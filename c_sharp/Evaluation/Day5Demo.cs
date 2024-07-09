namespace Evaluation;

public class Day5Demo
{
    List<Employee> employees = new List<Employee>
    {
        new Employee(1, "HR", 50000m, "Alice"),
        new Employee(2, "IT", 60000m, "Bob"),
        new Employee(5, "IT", 80000m, "Jack"),
        new Employee(3, "Finance", 55000m, "Charlie"),
        new Employee(7, "Finance", 60000m, "Miko"),
        new Employee(4, "Marketing", 45000m, "Diana"),
        new Employee(6, "Marketing", 45000m, "Mort"),
    };


    public IEnumerable<Employee> GetSalaryGreaterThan(decimal threshold)
    {
        var res = from employee in employees
            where employee.Salary > threshold
            orderby employee.Id
            select employee;
                
        return res;
    }
    
    public IEnumerable<Employee> GetSalaryGreaterThan2(decimal threshold)
    {
        
        return employees.OrderBy(e => e.Salary).ThenBy(e => e.Id).Where(e => e.Salary > threshold).Select(e => e);
    }
    
}