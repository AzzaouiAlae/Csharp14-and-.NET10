
/*
Write("A");
Write("B");
Write("C");
*/


/*
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35m;

WriteLine(
	format: "{0} apples cost {1:C}",
	arg0: numberOfApples,
	arg1: pricePerApple * numberOfApples
	);

string formatted = string.Format(
	format: "{0} apples cost {1:C}",
	arg0: numberOfApples,
	arg1: pricePerApple * numberOfApples
);
    
WriteLine(formatted);
*/

/*
WriteLine("{0} {1} lived in {2}.", 
	arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
    
WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}",
		"Roger", "Cevung", "Stockholm", "Education", "Optimizely");
        */
/*
int numberOfApples = 12;
decimal pricePerApple = 0.35m;

WriteLine($"{numberOfApples} apples cost {pricePerApple 
	* numberOfApples}");
*/
/*
const string college = "Mesq community college";
const string classs = "CIS262QD C# Level II";
const string combined = college + " - " + classs;

const string combined2 = $"{college} - {classs}";

Write($"""
              {college}
              {classs}
              {combined}
              {combined2}
              
              """);

*/

/*
const decimal num = 45454654.54m;

WriteLine($"{num:N0}");
*/
/*
var applesTest = "Apples";

var applesCout = 1234;

var bananasText = "Bananas";

var bananasCout = 56789;

WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");


WriteLine(format: "{0, -10} {1,6:N0}", arg0: applesTest, arg1: applesCout);
WriteLine(format: "{0, -10} {1,6:N0}", arg0: bananasText, arg1: bananasCout);
*/

/*
var value = 0.325m;

WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);
*/

/*
Write("Type your first name and press Enter: ");

var firstName = ReadLine();
if (firstName == null)
	WriteLine();
Write("Type your age and press ENTER: ");

var age = ReadLine();

if (age == null)
	WriteLine();

WriteLine($"Hello {firstName}, you look good for {age}.");
*/

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("key: {0}, char: {1}, Modifiers: {2}",
	key.Key, key.KeyChar, key.Modifiers);