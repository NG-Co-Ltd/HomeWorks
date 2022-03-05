int[,,] array = new int[3,5,4];
printThreeDimensionArray(array);


void printThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}