/*
WriteLine($"There are {args.Length} arguments.");

foreach(string arg in args)
{
	WriteLine(arg);
}
*/

if (args.Length < 3)
{
	WriteLine("You must specify two colors and cursor size, e.g.");
	WriteLine("dotnet run red yello 50");
	return ;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
	enumType: typeof(ConsoleColor),
	value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
	enumType: typeof(ConsoleColor),
	value: args[1], ignoreCase: true);

try
{
	CursorSize = int.Parse(args[2]);
} catch (PlatformNotSupportedException e)
{
	WriteLine(e.Message);
}

if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
	
}
else if (OperatingSystem.IsWindows())
{
	
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
	
}
else if (OperatingSystem.IsBrowser())
{
	
}
else if (OperatingSystem.IsLinux())
{
	
}
else if (OperatingSystem.IsMacOS())
{
	
}
