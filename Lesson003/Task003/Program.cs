/* Задача 21: Программа проверяет 
пятизначное число на палиндромом.
12 мин
Палиндром - слово или фраза (или число в нашем случае), 
которые одинаково читаются слева направо и справа 
налево.
Примеры: 545, 67876, 3443 */

System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = getNumberLength(number);
int result = 0;
checkPolindrom(number);


void checkPolindrom(int number)
{
    for (int i = 0; i < length; i++)
    {
        if (number.ToString()[i] == number.ToString()[length - i - 1])
        {
            System.Console.Write((i+1)+ "-number " + number.ToString()[i] + " == " + number.ToString()[length - i - 1] + " " + (length - i) + "-number");
            System.Console.WriteLine();
            result++;
        }
        else
        {
            System.Console.WriteLine("False!");
            break;
        }
    }
    if (result == length)
    {
        System.Console.WriteLine($"{number} is polindrom!");
    }
}


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