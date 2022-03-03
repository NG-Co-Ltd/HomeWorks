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
