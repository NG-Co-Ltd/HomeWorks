int[] numbers = { 9, 5, 4, 10, 7, 2, 1, 56956 };
SortMinMax(numbers);

static void SortMinMax(int[] numbers)
{
    PrintArray(numbers);
    int minNumber, minNumberIndex,
        maxNumber, maxNumberIndex;

    for (int i = 0; i < numbers.Length / 2; i++)
    {
        minNumber = numbers[i];
        minNumberIndex = i;
        maxNumber = numbers[i];
        maxNumberIndex = i;
        for (int j = 1 + i; j < numbers.Length - i; j++)
        {
            if (numbers[j] < minNumber)
            {
                minNumber = numbers[j];
                minNumberIndex = j;
            }
            else if (numbers[j] > maxNumber)
            {
                maxNumber = numbers[j];
                maxNumberIndex = j;
            }
        }
        if (numbers[i] > minNumber)
        {
            numbers[minNumberIndex] = numbers[i];
            numbers[i] = minNumber;
        }
        if (numbers[numbers.Length - i - 1] < maxNumber)
        {
            numbers[maxNumberIndex] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = maxNumber;
        }
    }

    PrintArray(numbers);
}

static void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}