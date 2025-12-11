


using Spectre.Console;

var table = new Table();

table.AddColumn(new TableColumn("Type"));
table.AddColumn(new TableColumn("Byte(s) of memory"));
table.AddColumn(new TableColumn("Min"));
table.AddColumn(new TableColumn("Max"));

table.AddRow("sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue}", $"{sbyte.MaxValue}");
table.AddRow("byte", $"{sizeof(byte)}", $"{byte.MinValue}", $"{byte.MaxValue}");
table.AddRow("short", $"{sizeof(short)}", $"{short.MinValue}", $"{short.MaxValue}");
table.AddRow("ushort", $"{sizeof(ushort)}", $"{ushort.MinValue}", $"{ushort.MaxValue}");
table.AddRow("int", $"{sizeof(int)}", $"{int.MinValue}", $"{int.MaxValue}");
table.AddRow("uint", $"{sizeof(uint)}", $"{uint.MinValue}", $"{uint.MaxValue}");
table.AddRow("long", $"{sizeof(long)}", $"{long.MinValue}", $"{long.MaxValue}");
table.AddRow("ulong", $"{sizeof(ulong)}", $"{ulong.MinValue}", $"{ulong.MaxValue}");
unsafe
{
	table.AddRow("int128", $"{sizeof(Int128)}", $"{Int128.MinValue}", $"{Int128.MaxValue}");
	table.AddRow("uint128", $"{sizeof(UInt128)}", $"{UInt128.MinValue}", $"{UInt128.MaxValue}");
	table.AddRow("Half", $"{sizeof(Half)}", $"{Half.MinValue}", $"{Half.MaxValue}");
}
table.AddRow("float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}");
table.AddRow("double", $"{sizeof(double)}", $"{double.MinValue}", $"{double.MaxValue}");
table.AddRow("decimal", $"{sizeof(decimal)}", $"{decimal.MinValue}", $"{decimal.MaxValue}");

for (int i = 1; table.Columns.Count > i; i++)
	table.Columns[i].Alignment(Justify.Right);

table.Expand();

AnsiConsole.Write(table);

