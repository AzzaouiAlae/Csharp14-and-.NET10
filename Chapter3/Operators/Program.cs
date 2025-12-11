using Spectre.Console;

Console.Clear();

//binary operators
/*
int x = 5;
int y = 3;
int resultOfAdding = x+y;
int resultOfMultiplying = x*y;
*/

//unary operators (work in a single operand)
/*
int x = 5;
int prostFixIncrement = x++;
int prefixIncrement = ++x;

Type theTypeOfAnInteger = typeof(int);
string nameOfValiable = nameof(x);
int howManyBytesInInteger = sizeof(int);
*/


//Ternary Operators
/*
var result = DateTime.Now.Second % 2 != 0 ? "odd": "even";
Console.WriteLine(result);
*/

#region Exploring unary operators
/*
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = a++;
WriteLine($"a is {c}, b is {d}");
*/
#endregion


#region Exploring binary arithmetic operators 
/*
int e = 11;
int f = 3;

WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
*/
#endregion


#region Assignment opeatiors
/*
int p = 6;

p += 3;
p -= 3;
p *= 3;
p /= 3;
WriteLine($"p is: {p}");
*/
#endregion


#region Null-coalescing operators

/*
string? authorName = GetAuthorName();

int maxLenght = authorName?.Length ?? 30;

authorName ??= "unknown";

WriteLine($"maxLenght: {maxLenght}, authorName: {authorName}");
*/

#endregion


#region  Exploring logical operators

/*
bool p = true;
bool q = false;


var table = new Table();
table.AddColumn("AND");
table.AddColumn(" p ");
table.AddColumn(" q ");
table.AddRow("p", $" {p & p} ", $" {p & q} ");
table.AddRow("q", $" {q & q} ", $" {q & q} ");
AnsiConsole.Write(table);
WriteLine();

table = new Table();
table.AddColumn("OR ");
table.AddColumn(" p ");
table.AddColumn(" q ");
table.AddRow("p", $" {p | p}  ", $" {p | q} ");
table.AddRow("p", $" {q | p}  ", $" {q | q} ");
AnsiConsole.Write(table);
WriteLine();


table = new Table();
table.AddColumn("XOR");
table.AddColumn(" p ");
table.AddColumn(" q ");
table.AddRow("p", $" {p ^ p} ", $" {p ^ q} ");
table.AddRow("p", $" {q ^ p} ", $" {q ^ q} ");
AnsiConsole.Write(table);
WriteLine();


WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");



*/

#endregion


#region Exploring conditinal logical operators
/*
bool p = true;
bool q = false;

WriteLine($"p & DoStuff() = {p && DoStuff()}");
WriteLine($"q & DoStuff() = {q && DoStuff()}");
*/
#endregion


#region Eploring bitwise and binary shift operators
/*
WriteLine();
int x = 10;
int y = 6;
var table = new Table();
table.AddColumn("Expression");
table.AddColumn("Decimal");
table.AddColumn("Binary");
table.AddRow("x", $" {x} ", $"{x:B8}");
table.AddRow("y", $" {y} ", $"{y:B8}");
table.AddRow("x & y", $" {x & y} ", $"{x & y:B8}");
table.AddRow("x | y", $" {x | y} ", $"{x | y:B8}");
table.AddRow("x << 3", $" {x << 3} ", $"{x << 3:B8}");
table.AddRow("x * 8", $" {x * 8} ", $"{x * 8:B8}");
table.AddRow("x >> 1", $" {x >> 1} ", $"{x >> 1:B8}");
table.AddRow("(1L << 31) - 1", $" {(1L << 31) - 1} ", $"{(1L << 31) - 1:B8}");

AnsiConsole.Write(table);
*/
#endregion


#region Miscellaneous operators
/*
int age = 50;
WriteLine($"The {nameof(age)} variable uses {sizeof(int)} bytes with is {4 << 3} bits of memory.");

// How many operators in the following statement?
char firstDigit = age.ToString()[0];
// There are four operators:
// = is the assignment operator
// . is the member access operator
// () is the invocation operator
// [] is the indexer access operator
*/

#endregion





return;
/*


string? GetAuthorName()
{
	Random a = new();
	int rn = a.Next();
	if (rn % 2 == 0)
		return "alae";
	return null;
}


public class Customer
{
	public required string Name {get; set;}
	public int Age {get; private set;}

	public static void UpadteAge(Customer? customer, int newAge)
	{
		// if (customer is not null)
		// 	customer.Age = newAge;
		customer?.Age = newAge;
	}

};

static bool DoStuff()
{
	WriteLine("I am doing some stuff.");
	return true;
}
*/