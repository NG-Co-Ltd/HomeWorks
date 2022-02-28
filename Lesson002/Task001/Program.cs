/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа. */

System.Console.Write("Enter 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
number = getTwoDigit(number);
System.Console.WriteLine(number);
int getTwoDigit(int number)
{
    number %= 100;
    return number / 10;
}