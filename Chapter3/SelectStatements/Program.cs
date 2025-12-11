using SelectStatements;

Clear();


#region Branching with the if statement
/*
Write("Enter your password: ");
string password = ReadLine() ?? "";

if (password.Length < 8)
	WriteLine("Your password is too short. Use at least 8 chars.");
else
	WriteLine("Your password is strong.");
*/
#endregion

#region Early return or Guard clause style if statements

/*
static  string GetStatus(int score)
{
	if (score >= 50)
	{
		return "Pass";
	}
	else
	{
		return "Fail";
	}
}
*/

/*
static string GetStatus(int score)
{
	if (score < 50)
	{
		return "Fail";
	}
	return "Pass";
}
*/


#endregion

#region Patteren matching with the if statement
/*
object o = 3;
int j = 4;

if (o is int i)
{
	WriteLine($"{i} x {j} = {i * j}");
}
else
{
	WriteLine($"o is not an int so it canot multiply!");
}
*/
#endregion

#region Branching with the switch statement

/*
int number = Random.Shared.Next(minValue: 1, maxValue: 7);

switch(number)
{
	case 1:
		WriteLine("One");
		break;
	case 2:
		WriteLine("Two");
		goto case 1;
	case 3:
	case 4:
		WriteLine("Three or four");
		goto case 1;
	case 5:
		goto A_label;
	default:
		WriteLine("Default");
		break;
}
WriteLine("Afterend of switch");
A_label:
WriteLine("After A_label");
*/

#endregion

#region Pattern matching with the switch statement

var animals = new Animal?[]
{
	new Cat 
	{
		Name = "Karen", 
		Born = new (year: 2022, month: 8, day: 23), 
		Legs = 4, 
		IsDomestic = true
	}, 
	null,
	new Cat
	{
		Name = "Mufasa",
		Born = new (year: 1994, month: 6, day: 12),
	},
	new Snake
	{
		Name = "Sid Vicious",
		Born = DateTime.Today,
		IsVenomous = true	
	},
	new Snake
	{
		Name = "Captain Furry",
		Born = DateTime.Today
	}
};

foreach(Animal ? animal in animals)
{
	string message;

	switch(animal)
	{
		case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
			message = $"The cat named {fourLeggedCat.Name} has four legs.";
			break;
		case Cat wildCat when wildCat.IsDomestic == false:
			message = $"the non-domestic cat is named {wildCat.Name}";
			break;
		case Cat cat:
			message = $"The cat is named {cat.Name}";
			break;
		default:
			message = $"{animal?.Name} is a {animal?.GetType().Name}.";
			break;
		case Snake snake when snake.IsVenomous:
			message = $"The {snake.Name} snake is venomous. Run!";
			break;
		case null:
			message = "The animal is null";
			break;
	}
	
	WriteLine($"switch statement: {message}");

	message = animal switch
	{
		Cat fourLeggedCat when fourLeggedCat.Legs == 4
			=> $"The cat named {fourLeggedCat.Name} has four legs.",
		Cat wildCat when wildCat.IsDomestic == false
			=> $"The non-domestic cat is named {wildCat.Name}.",
		Cat cat 
			=> $"The cat is named {cat.Name}.",
		Snake snake when snake.IsVenomous
			=> $"The {snake.Name} snake is venomous. Run!",
		null 
			=> "The animal is null.",
		_
			=> $"{animal.Name} is a {animal.GetType().Name}."
	};
	WriteLine($"switch expression: {message}");
}

#endregion


return;
