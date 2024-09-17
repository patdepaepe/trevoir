// See https://aka.ms/new-console-template for more information

string name = string.Empty;
int age = 0;
int retirementAge = 65;


Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Full Name: {name}");
Console.WriteLine($"Age: {age}");
int workingYearsLeft = retirementAge - age;
Console.WriteLine($"Working Years remaining: {workingYearsLeft}");


