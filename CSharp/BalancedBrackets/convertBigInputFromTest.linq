<Query Kind="Statements" />

string[] rawOutupt = File.ReadAllLines(@"C:\personal-repos\Exercises\CSharp\BalancedBrackets\BracketInput.txt");


StringBuilder builder = new StringBuilder();

foreach (var singleLine in rawOutupt)
{
	builder.AppendLine($"\"{singleLine}\",");
}

builder.ToString().Dump();