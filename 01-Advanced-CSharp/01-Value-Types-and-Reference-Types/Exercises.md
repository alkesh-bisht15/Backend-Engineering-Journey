//Problem 1
//What will this print?

int a = 10;
int b = a;

b = 50;

Console.WriteLine(a);
Console.WriteLine(b);
//Answer : 10, 50

//Problem 02
//What will this print?

Person p1 = new Person();
p1.Name = "Alkesh";

Person p2 = p1;

p2.Name = "Rahul";

Console.WriteLine(p1.Name);
//Answer : Rahul



//Problem 03
//Explain the difference between: 
/* ref
out
in
*/

/*ref : It reads and modifies the value of the parameter passed to the method.
The variable must be initialized before being passed to the method.*/

/* out : It is used to return multiple values from a method. 
The variable does not need to be initialized before being passed to the method, 
but it must be assigned a value before the method returns.*/

/* in : It is used to pass a read-only reference to a method.
The variable must be initialized before being passed to the method, 
and it cannot be modified within the method. 
It is used to improve performance by avoiding unnecessary copying of large value types. */

//Problem 04
//Create :

BankAccount account1 = new BankAccount();
BankAccount account2 = account1;

account2.Balance = 1000;
Console.WriteLine(account1.Balance);

//Answer  : 1000

//Problem 05
//Create : 

Counter c1 = new Counter();
c1.Value = 10;

Counter c2 = c1;

c2.Value = 50;

//c1.Value will still be 10 because Counter is a struct, which is a value type. 
// When c2 is assigned to c1, a copy of c1 is made, so changes to c2 do not affect c1.



struct Counter
{
    public int Value;
}


class Person
{
    public string Name { get; set; }
}

class BankAccount
{
    public decimal Balance { get; set; }
}