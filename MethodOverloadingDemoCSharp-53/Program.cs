namespace MethodOverloadingDemoCSharp_53;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine(true);
        // Console.WriteLine(23);
        // Console.WriteLine('d');

        var addedNumbers = Add(2.5, 2.5);
        Console.WriteLine(addedNumbers);
        
        Greet("Seth", "Bowman", 30);
        Greet();
    }

    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static double Add(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }

    public static void Greet(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}!");
    }

    public static void Greet(string firstName, string lastName)
    {
        Console.WriteLine($"Hello, {firstName} {lastName}!");
    }

    public static void Greet(string firstName, string lastName, int age)
    {
        if (age >= 21)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}! You are allowed in to the bar.");
        }
        else
        {
            Console.WriteLine($"Hello, {firstName} {lastName}! Sorry, you are not allowed in to the bar.");
        }
    }

    public static void Greet()
    {
        Console.WriteLine("Hello!");
    }
}