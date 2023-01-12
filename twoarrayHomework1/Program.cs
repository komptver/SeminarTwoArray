﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[3, 4];
Show2dArray(matrix);
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Функция заполнения массива случайными числами от 1 до 10
void Show2dArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
           {
            matrix[i, j] = new Random().Next(1,10);
           }       
    }    
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
                Console.WriteLine("");
           
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int step = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = step;
                }
            }
        }
    }
}
