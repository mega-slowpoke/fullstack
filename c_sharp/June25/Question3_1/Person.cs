namespace Main;

public class Person : IPersonService
{
    private int Age;

    public int Id { get; set; }
    public string Name { get; set; }
        
    public decimal Salary
    {
        get
        {
            return Salary;
        }
        set
        {
            if (Salary < 0)
            {
                Console.WriteLine("Salary cannot be negative");
                return;
            }

            Salary = value;
        } 
    }
    public List<string> Addresses { get; set; }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int CalculateAge()
    {
        return Age;
    }

    public virtual decimal CalculateTotalSalary()
    {
        return 0;
    }

    public void AddAddress(string address)
    {
        Addresses.Add(address);
    }
}