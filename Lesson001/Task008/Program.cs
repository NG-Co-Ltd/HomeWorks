﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteNumbers(number);



void WriteNumbers(int number)
{
    if (number % 2 == 0)
    {
        for (int i = 1; i <= number; i++)
        {   
            if (i == number)
            {
                System.Console.Write(i);
                break;
            }
            if (i % 2 == 0)
            {
                System.Console.Write(i + ", ");
            }
        }
    }
    else
    {
        for (int i = 1; i <= number; i++)
        {
            if (i == number - 1)
            {
                System.Console.Write(i);
                break;
            }
            if (i % 2 == 0)
            {
                System.Console.Write(i + ", ");
            }
        }
    }
}
