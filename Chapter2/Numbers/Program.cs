Console.Clear();
uint naturalNumber = 23;

int integerNUmber = -23;

float realNumber = 2.3f;

double anotherRealNumber = 2.3;

int decimalNotation = 2_000_000;

int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;

int hexadecimalNotation = 0x_001E_8480;
/*
System.Console.WriteLine($"""
naturalNumber    	= {naturalNumber}
integerNUmber    	={integerNUmber}
realNumber       	=  {realNumber}
anotherRealNumber	=  {anotherRealNumber}
decimalNotation  	= {decimalNotation}
binaryNotition   	= {binaryNotation}
hexadecimalNotation	= {hexadecimalNotation}
""");
*/

System.Console.WriteLine($"""


int uses {sizeof(int)} bytes and can store numbers in range 
{int.MinValue} 
to
{int.MaxValue}

double uses {sizeof(double)} bytes and can store numbers in range 
{double.MinValue:N0} 
to
{double.MaxValue:N0}

decimal uses {sizeof(decimal)} bytes and can store numbers in the range 
{decimal.MinValue:N0}
to
{decimal.MaxValue:N0}
""");

/*

Console.WriteLine("Using doubles:");
double a = 0.1f;
double b = 0.2f;

if (a + b == 0.3f)
	Console.WriteLine($"{a} + {b} equals {0.3}");
else
	Console.WriteLine($"{a} + {b} does not equal {0.3}");


Console.WriteLine("Using decimals:");
decimal c = 0.1m;
decimal d = 0.2m;
if (c + d == 0.3m)
	Console.WriteLine($"{c} + {d} equals {0.3m}");
else
	Console.WriteLine($"{c} + {d} does NOT equal {0.3m}");
*/
/*
const double d = 0;
const double n = 0 / d;

const int col1 = 37;
const int col2 = 6;
var line = new string('-', col1 + col2 + 3);

Console.WriteLine($"""
nan: {n}

double.Epsilon: {double.Epsilon}

double.Epsilon to 324 decimal places: {double.Epsilon:N324}

double.Epsilon to 330 decimal places: {double.Epsilon:N330}

{line}

{"Expression", -col1} | {"Value", col2}
{line}
{"double.NaN", -col1} | {double.NaN, col2}
{"double.PositiveInfinity", -col1} | {double.PositiveInfinity, col2}
{"double.NegativeInfinity", -col1} | {double.NegativeInfinity, col2}
{line}
{"0.0 / 0.0", -col1} | {0.0 / 0.0, col2}
{"3.0 / 0.0", -col1} | {3.0 / 0.0, col2}
{"-3.0 / 0.0", -col1} | {-3.0 / 0.0, col2}
{"3.0 / 0.0 == double.PositiveInfinity", -col1} | {3.0 / 0.0 == double.PositiveInfinity}
{"-3.0 / 0.0 == double.NegativeInfinity", -col1} | {-3.0 / 0.0 == double.NegativeInfinity}
{"0.0 / 3.0", -col1} | {0.0 / 3.0, col2}
{"0.0 / -3.0", -col1} | {0.0 / -3.0, col2}
""");
*/
/*
unsafe
{
	Console.WriteLine($"""
Half uses {sizeof(Half)} byte and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}
Int128 uses {sizeof(Int128)} bytes and can store numbers in the range 
{Int128.MinValue:N0} 
to 
 {Int128.MaxValue:N0}
""");
}
*/