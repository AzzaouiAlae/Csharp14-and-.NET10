using System;

namespace SelectStatements;

public class Animal
{
	public required string Name;
	public DateTime Born;
	public byte Legs;
}

class Cat : Animal
{
	public bool IsDomestic;
}

class Snake : Animal
{
	public bool IsVenomous;
}