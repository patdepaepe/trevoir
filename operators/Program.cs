// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the sample calculator");

Console.Write("please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please select an operation: ");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

int result = 0;
switch (choice)
{
    case 1:
        result = num1 + num2;
        break;

    case 2:
        result = num1 - num2;
        break;

    case 3:
        result = num1 * num2;
        break;
    case 4:
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;

     

}

Console.WriteLine($"The result is {result}");
Console.ReadLine();