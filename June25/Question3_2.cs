namespace Main;

public class Question3_2
{
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void GoToClassroom() {}
    }

    public class Student : Person
    {
        public Student(string name, int age) : base(name, age) {}

        public override void GoToClassroom()
        {
            Console.WriteLine($"Student {Name} goes to classroom and scroll through his phone");
        }

     
    }

// Instructor class inheriting from Person and implementing specific behavior
    public class Instructor : Person
    {
        public string Title { get; set; }

        public Instructor(string name, int age, string title) : base(name, age)
        {
            Title = title;
        }

        public override void GoToClassroom()
        {
            Console.WriteLine($"Instructor {Name} goes to classroom and brags about his PhD life");
        }
    }
}