//#error version
// WriteLine();
// WriteLine("Hello Ahmed");
// WriteLine("Temperature on {0:D} is {1}°C", DateTime.Today, 23.4);

// System.Data.DataSet ds = new();
// HttpClient client = new();

// var myApp = Assembly.GetEntryAssembly();

// if (myApp == null)
// 	return ;

// foreach (var name in myApp.GetReferencedAssemblies())
// {
// 	var a = Assembly.Load(name);

// 	var methodCount = a.DefinedTypes.Sum(t => t.GetMethods().Length);

// 	WriteLine("{0:N0} type with {1:N0} methods in {2} assembly.", 
// 		arg0: a.DefinedTypes.Count(),
// 		arg1: methodCount,
// 		arg2: name.Name);
// }

// double heightInMeters = 1.88;
// Console.WriteLine($"The variable {nameof(heightInMeters)} has value {heightInMeters}.");

// var userChoice = GetChar();

// Console.WriteLine("\n\n{0}", userChoice);

// WriteLine("hello\vworld");

// const string xml = """
// 	<person age="50">
// 		<first_name>Mark</first_name>
// 	</person>
// 	""";

var person = new { FirstName = "Alice", Age = 56};

var json = $$"""
{
	"first_name": "{{person.FirstName}}",
	"age": {{person.Age}},
	"calculation": "{3}"
}
""";

// WriteLine(xml);
WriteLine(json);


// return;

// static char GetChar() => ReadKey().KeyChar;