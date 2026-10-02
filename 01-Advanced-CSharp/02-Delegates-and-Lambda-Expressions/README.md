# Day 2 — Delegates & Lambda Expressions

## 📚 Topics Covered

- Delegates
- Delegate declaration and invocation
- Passing methods as parameters
- Multicast delegates
- Lambda expressions
- Lambda expressions with delegates
- Using delegates to make behavior configurable

---

## 🔹 Delegates

A delegate is a type-safe reference to a method.

It allows us to pass methods as parameters and treat
behavior like a value.

### Basic Example

```csharp
delegate void Operation(int number);

static void PrintNumber(int number)
{
    Console.WriteLine(number);
}

Operation operation = PrintNumber;
operation(10);
```
---

## 🔹 Lambda Expressions

Lambda expressions provide a concise way to write
anonymous functions.

Example:
```csharp
Func<int, int> square = number => number * number;

Console.WriteLine(square(5));
```
Here, (number => number * number) is the lambda expression

---

## 🔹 Why This Matters in Backend Development

Delegates and lambdas are heavily used in modern C# and
.NET applications.

They are commonly seen with:

LINQ
Callbacks
Events
Middleware
Dependency Injection
Collection processing
Strategy-like behavior

---

## 🧪 Practical Exercise

### Transaction Processor

I created a TransactionProcessor that can perform
different transaction-processing behaviors using delegates.

The goal was to understand how behavior can be passed
into a method instead of hard-coding one specific behavior.

### 🧠 Key Takeaways

1. A delegate can reference a method.
2. Methods can be passed as parameters.
3. Lambda expressions provide a concise way to create functions.
4. Delegates allow behavior to be changed without changing the main processing logic.
5. This concept is important for understanding LINQ and many parts of modern .NET.

