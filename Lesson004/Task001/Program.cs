// Найти сумму чисел от 1 до а 

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? string.Empty);
int result = findSumOf1ToN(number);
Console.WriteLine($"Sum of 1 to {number} = {result}");

int findSumOf1ToN(int number)
{
    return number * (number + 1) / 2;
}