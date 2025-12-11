namespace CSharp13New_s;

public static class TestParams
{
	public static void Print(params List<string> myList)
	{
		myList = myList[1..^3];
		foreach (var s in myList)
		{
			Console.Write(s);
		}

		Console.WriteLine();
	}
}
