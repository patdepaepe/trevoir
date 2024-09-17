// See https://aka.ms/new-console-template for more information

string firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;


Console.Write("Enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter your gender(m or f): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you employed (true olr false):  ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is:{salary}");
Console.WriteLine($"Yiur gender is: {gender}");
Console.WriteLine($"Are you working: {working}");
int workingYearsLeft = retirementAge - age;
Console.WriteLine($"Working Years remaining: {workingYearsLeft}");


