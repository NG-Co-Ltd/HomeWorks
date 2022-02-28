/* 16. Напишите программу, которая принимает на вход два числа и
 проверяет, является ли второе число квадратом первого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  нет
8,9  ->  нет */

System.Console.Write("Enter 1-number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter 2-number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
checkSquare(number1, number2);

void checkSquare(int number1, int number2)
{
    if (number1 * number1 == number2)
    {
        System.Console.WriteLine("True");
    }
    else
    {
        System.Console.WriteLine("False");
    }
}