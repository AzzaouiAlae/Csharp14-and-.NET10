#!/usr/bin/dotnet run
#:package Humanizer@*

using System;
using Humanizer;

Console.Clear();
Console.WriteLine(TimeSpan.FromDays(1).Humanize());