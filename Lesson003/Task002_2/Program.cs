/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

System.Console.Write("Enter quarter: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    System.Console.WriteLine("x > 0 && y > 0");
}
else if (x == 2)
{
    System.Console.WriteLine("x < 0 && y > 0");
}
else if (x == 3)
{
    System.Console.WriteLine("x < 0 && y < 0");
}
else if (x == 4)
{
    System.Console.WriteLine("x > 0 && y < 0");
}
else
{
    System.Console.WriteLine("Zero");
}
