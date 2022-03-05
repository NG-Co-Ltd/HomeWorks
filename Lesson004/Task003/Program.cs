// Написать программу вычисления произведения чисел от 1 до n
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? string.Empty);
for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i} ");
}