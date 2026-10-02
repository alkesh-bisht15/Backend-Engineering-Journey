public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Square(5));

        action("Hello, World!");

        Console.WriteLine(isPositive(5));

        var greaterThan = numbers.Where(n => n > 10);

        Console.WriteLine("Numbers greater than 10:" + string.Join(", ", greaterThan));

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Squares of numbers: " + string.Join(", ", squares));

        var firstNumberGreaterThanFifteen = numbers.FirstOrDefault(n => n > 15);
        Console.WriteLine("First number greater than fifteen: " + firstNumberGreaterThanFifteen);
    }

    static List<int> numbers = new()
    {
        5, 12, 7, 20, 3, 18, 25
    };
    public static Func<int, int> Square = x => x * x;

    public static Action<string> action = message => Console.WriteLine(message);

    public static Predicate<int> isPositive = x => x > 0;

    
}