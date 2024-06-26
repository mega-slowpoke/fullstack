namespace Main;

public class Question3_1
{
    // Abstraction: abstract class defining common behavior
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void MakeSound();  // Abstract method
    }

    // Encapsulation: using private fields and public properties to access them
    // Inheritance: deriving classes Dog and Cat to extend behaviors
    public class Dog : Animal
    {
        private string breed;

        public Dog(string name, string breed)
        {
            Name = name;
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

       
    }

    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        
        // Polymorphism: compile-time polymorphism, method overload 
        public void Eat(double fishWeight)
        {
            Console.WriteLine($"${{Name}} eats {fishWeight} pounds fish");
        }

        public void Eat(int mouseNum)
        {
            Console.WriteLine($"${{Name}} eats {mouseNum} mice");
        }
    }
    
    // Polymorphism: runtime polymorphism, MakeSound() can have different behaviors 
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog("Buddy", "Labrador");
            Animal cat = new Cat("Whiskers");
            dog.MakeSound();
            Console.WriteLine();
            cat.MakeSound();
        }
    }
}