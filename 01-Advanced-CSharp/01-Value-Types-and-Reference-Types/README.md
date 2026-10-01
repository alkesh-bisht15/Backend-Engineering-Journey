# Value Types vs Reference Types

## What I Learned

In C#, types can behave differently when variables are
assigned to each other.

The important distinction I learned today is between
reference types and value types.

## Reference Types

Classes are reference types.

When one variable is assigned to another, both variables
can refer to the same object.

Example:

Person p1 = new Person();
Person p2 = p1;

Changing the object through p2 can therefore be observed
through p1.

## Value Types

Structs are value types.

When a value-type variable is assigned to another variable,
the value is copied.

Example:

Counter c1 = new Counter();
Counter c2 = c1;

Changing c2 does not change c1.

## Key Difference

Reference type:

Variable → Reference → Object

Value type:

Variable → Value

## Backend Relevance

Understanding value and reference semantics is important
when working with:

- Entity Framework Core
- DTOs
- Dependency Injection
- Collections
- Performance
- Memory management
- Multithreading
- API models

## Key Takeaway

The most important thing I learned today is that assigning
a reference type variable copies the reference, while
assigning a value type copies the value.