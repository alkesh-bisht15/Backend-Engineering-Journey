using System;

class Person
{
    public string Name { get; set; } = "";
}

struct Counter
{
    public int Value { get; set; }
}

class Program
{
    static void Main()
    {
        // Reference type
        Person p1 = new Person { Name = "Alkesh" };
        Person p2 = p1;

        p2.Name = "Rahul";

        Console.WriteLine($"p1.Name: {p1.Name}");
        Console.WriteLine($"p2.Name: {p2.Name}");

        // Value type
        Counter c1 = new Counter { Value = 10 };
        Counter c2 = c1;

        c2.Value = 20;

        Console.WriteLine($"c1.Value: {c1.Value}");
        Console.WriteLine($"c2.Value: {c2.Value}");
    }
}

//Expected Output : 
/*p1.Name: Rahul
p2.Name: Rahul

c1.Value: 10
c2.Value: 20 */

//The important observation is : 
/*Person
p1 ──────┐
         ├──> same object
p2 ──────┘

Counter
c1 ──> 10

c2 ──> 10   ← copied value */