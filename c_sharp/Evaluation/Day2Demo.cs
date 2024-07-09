namespace Evaluation;

public class Day2Demo
{
    // Encapsulation
    // Inheritance
    // Abstraction
    // Polymorphism : Compile-time -> overloading / overriding 
    //                Runtime      -> Upcast
}

// abstract / virtual to be overridden




// static class is "static", it cannot be inherited, initialized and only contains static stuff
// abstract class -> cannot be initialized, sealed class -> cannot be inherited, other than that, they are just normal classes
public static class StaticClassTest
{
    public static void StaticMethod() {
        Console.WriteLine("This is a static method in a static nested class.");
    }
    
}


// add a customized method to 
public static class ExtensionDemo
{
    public static bool IsPan(this string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}