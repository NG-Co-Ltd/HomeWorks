/* Задача 17: По двум заданным 
числам проверять является ли одно 
квадратом другого. */

System.Console.Write("Enter 1-number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter 2-number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
{
    System.Console.WriteLine("The second number is the square of the first number!");
}
else if (number2 * number2 == number1)
{
    System.Console.WriteLine("The first number is the square of the second number!");
}
else
{
    System.Console.WriteLine("None of the numbers is the square of the other!");
}

