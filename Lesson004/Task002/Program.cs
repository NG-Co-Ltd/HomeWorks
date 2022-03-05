// Определить количество цифр в числе
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? string.Empty);

int len = getNumberLength(number);
Console.WriteLine($"The number of digits in a number: {len}");

int getNumberLength(int number)
{
    if (number == 0)
    {
        return 1;
    }
    int numberLength = 0;
    while (number > 0)
    {
        number /= 10;
        numberLength++; 
    }
    return numberLength;
}
