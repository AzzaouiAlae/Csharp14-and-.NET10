
/*
object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");
// int lenght1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");
*/

/*
dynamic something;

something = new[] { 3, 5, 7 };

something = 12;

// something = "Ahmed";
try {	
	Console.WriteLine($"The lenght of somthing is {something.Length}");
} catch (Exception e) {
	Console.WriteLine($"{e.Message}");
	Console.WriteLine($"sonthing is a {something.GetType()}");
}
*/
/*
dynamic person = new ExpandoObject();

person.FirstName = "John";
person.LastName = "Doe";
person.Age = 30;

Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
var dictionary = (IDictionary<string, object>)person;

foreach (var item in dictionary)
	Console.WriteLine($"{item.Key} = {item.Value} | {item.Value.GetType()}");
*/

/*
int population = 60_000_000;

double weight = 1.88;

decimal price = 4.99m;

string fruit = "Apples";

char letter = 'Z';

bool happy = true;
*/

/*
var population = 67_000_000;

var weight = 1.88;

var price = 4.99m;

var fruit = "Apple";

var letter = 'Z';

var happy = true;
*/

/*
var xml1 = new XmlDocument();

XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
file1.Write("""
            <h1>Hello</h1>
            
            """);
file1.Close();
StreamWriter file2 = File.CreateText("something2.txt");
*/

/*
Console.WriteLine($"default(int) {default(int)}");
Console.WriteLine($"default(bool) {default(bool)}");
Console.WriteLine($"default(DateTime) {default(DateTime)}");
Console.WriteLine($"default(string) {default(string) ?? "null"}");
*/


int num = 13;
Console.WriteLine($"Number set to: {num}");
num = default;
Console.WriteLine($"Number reset to its defualt: {num}");