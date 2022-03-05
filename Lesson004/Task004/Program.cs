// Задать массив из 8 элементов и вывести их на экран
int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100);
}
PrintArray(numbers);

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
}