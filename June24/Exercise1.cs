/* QUESTION 1
 1.1
    A person’s telephone number: string
    A person’s height: double
    A person’s age: int
    A person’s gender (Male, Female, Prefer Not To Answer): Enum
    A person’s salary: decimal
    A book’s ISBN: string
    A book’s price: double
    A book’s shipping weight: double
    A country’s population: int (there is no country has people more than 2 billion)
    The number of stars in the universe: BigInteger
    The number of employees: int
 
 1.2
    1. Value type holds the value while reference type holds the memory address of the value. 
    2. Value types -> stack memory, reference types -> heap memory. 
    3. Value type will not be collected by garbage collector but reference type will be collected by garbage collector. 
    4. The value type can be created by struct or enum while reference type can be created by class, interface, delegate or array.
    5. Value type cannot be null while reference types can be null.
    
 1.3
    There are two kinds of heap memory in c#
    managed resources are those being collected by c# garbage collector. e.g: objects
    unmanaged resources are those not being managed by GC. Programmers have to explicitly manage
    them with Dispose() of IDispose. e.g: database connection, file I/O
    
 1.4
    In C/C++, programmers need to manually manage memory with free/malloc. GC provides us with a
    higher level of abstraction and does memory management for us under the hood.
 */

using System.Numerics;

void NameGenerator()
{
    while (true)
    {
        Console.WriteLine("Enter your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("What is your astrology sign?");
        string sign = Console.ReadLine();
        Console.WriteLine("What is your street address number?");
        string streetAddressNumber = Console.ReadLine();

        Console.WriteLine($"Your hacker name is {color}{sign}{streetAddressNumber}.");
    }
}


void PrintTypeSize()
{
    Console.WriteLine($"sbyte: {sizeof(sbyte)}, range: {sbyte.MinValue} to {sbyte.MaxValue}");
    Console.WriteLine($"byte: {sizeof(byte)}, range: {byte.MinValue} to {byte.MaxValue}");
    Console.WriteLine($"short: {sizeof(short)}, range: {short.MinValue} to {short.MaxValue}");
    Console.WriteLine($"ushort: {sizeof(ushort)}, range: {ushort.MinValue} to {ushort.MaxValue}");
    Console.WriteLine($"int: {sizeof(int)}, range: {int.MinValue} to {int.MaxValue}");
    Console.WriteLine($"uint: {sizeof(uint)}, range: {uint.MinValue} to {uint.MaxValue}");
    Console.WriteLine($"long: {sizeof(long)}, range: {long.MinValue} to {long.MaxValue}");
    Console.WriteLine($"ulong: {sizeof(ulong)}, range: {ulong.MinValue} to {ulong.MaxValue}");
    Console.WriteLine($"float: {sizeof(float)}, range: {float.MinValue} to {float.MaxValue}");
    Console.WriteLine($"double: {sizeof(double)}, range: {double.MinValue} to {double.MaxValue}");
    Console.WriteLine($"decimal: {sizeof(decimal)}, range: {decimal.MinValue} to {decimal.MaxValue}");
}


void CenturyConverter(int century)
{

    BigInteger mill = new BigInteger(century);
    mill *= 3155673600000;
    BigInteger micro = new BigInteger(century);
    micro *= 3155673600000000;
    BigInteger nano = new BigInteger(century);
    nano *= 3155673600000000000;
    Console.WriteLine($"{century} centuries = " +
                      $"{(ulong)century * 100} years = " +
                      $"{(ulong)century * 36524} days = " +
                      $"{(ulong)century * 876576} hours = " +
                      $"{(ulong)century * 52594560} minutes= " +
                      $"{(ulong)century * 3155673600}seconds = " +
                      $"{mill} milliseconds = " +
                      $"{micro} microseconds = " +
                      $"{nano} nanoseconds");
}


/*
 * Controlling Flow and Converting Types

1.  int x = 1/0; -> compile error
    
    int zero = 0;
    int randomNum = 1000;
    int res = randomNum / zero -> runtime eroor

2. return infinity

3. compile error

4. x = y++ -> assign value first and then increment y
   x = ++y -> increment y and then assign value 

5. break : break from a loop
   continue: skip the current round
   return : break from current function 

6. initializer(optional), condition (required), iterator (optional)  

7. = is assignment operator while == is to check if two things are the equal

8. it compiles, a infinite loop

9. default case / any case remaining

10. System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T>
 */


void FizzBuzz()
{
    for (int i = 1; i <= 100; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
            Console.WriteLine("fizzbuzz");
        } else if (i % 3 == 0) {            
            Console.WriteLine("fizz");
        } else if (i % 5 == 0) {
            Console.WriteLine("buzz");
        } else {
          Console.WriteLine(i);  
        }
    }
}

/*
 * 1.1
 * 
 * The following code will cause a infinite loop because byte in c# can only hold number
 * 0-255, whenever i reach 255, it will become 0 next time
 *
 * We can add a if statement to alert about this and break
 */
void ByteOverflow()
{
    int max = 500;
    for (byte i = 0; i < max; i++)
    {
        Console.WriteLine(i);
    }
}

/*
 * 1.2
 */
void GuessNumber()
{
    int randomNumber = new Random().Next(3) + 1;
    while (true)
    {
        Console.WriteLine("Guess the number");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > 3)
        {
            Console.WriteLine("Out of bound, enter a number between 1 and 3.");
        }
        else if (input < randomNumber)
        {
            Console.WriteLine("Your guess is too low. Try again.");
        }
        else if (input > randomNumber)
        {
            Console.WriteLine("Your guess is too high. Try again.");
        }
        else
        {
            Console.WriteLine("You got it");
            break;
        }
    }
}

/*
 * 2
 */
void PrintPyramid(int level)
{
    for (int i = 0; i < level; i++)
    {
        for (int space = 0; space < level - i - 1; space++) 
        { 
            Console.Write(" ");
        }

        for (int star = 0; star < i * 2 +1; star++)
        {
            Console.Write("*");
        }
        
        Console.WriteLine();
    }
}

/*
 * 3 is duplicate of 1.2
 */
 
 
/*
 * 4
 * dateOfBirth 1980-01-01
 */
int GetAge(string dateOfBirth)
{
    int year = int.Parse(dateOfBirth.Substring(0, 4));
    int month = int.Parse(dateOfBirth.Substring(5, 2));
    int day = int.Parse(dateOfBirth.Substring(8, 2));

    DateTime birth = new DateTime(year, month, day);
    int diff = DateTime.Today.Year - birth.Year;

    if (DateTime.Today.Month < birth.Month || (DateTime.Today.Month == birth.Month && DateTime.Today.Day < birth.Day))
    {
        diff--;
    }

    return diff;
}

/*
 * 5
 */
void Greet()
{
    int curHour = DateTime.Now.Hour;
    
    if (curHour >= 6 && curHour < 12)
    {
        Console.WriteLine("Good Morning");
    }

    if (curHour >= 12 && curHour < 18)
    {
        Console.WriteLine("Good Afternoon");
    }

    if (curHour >= 18)
    {
        Console.WriteLine("Good Evening");
    }

    if (curHour < 6)
    {
        Console.WriteLine("Good Night");
    }
}

/*
 * 6
 */
void Count24()
{
    for (int outer = 1; outer <= 4; outer++)
    {
        for (int inner = 0; inner <= 24; inner += outer)
        {
            if (inner != 0)
            {
                Console.Write(",");
            }
            Console.Write(inner);
        }
        Console.WriteLine();
    }
}

Exercise2 ex = new Exercise2();
int[] res = ex.LongestSubarray(new int[]{0 ,1, 1, 5, 2, 2, 6, 3, 3});
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}