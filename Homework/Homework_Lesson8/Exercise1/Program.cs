﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//                        строки     столбцы
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Упорядочивание по убыванию элементов каждой строки:
int[,] LineOrder(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for(int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if(matrix[i, k] < matrix[i, k+1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k+1];
                    matrix[i, k+1] = temp;
                }
            }
        }
    }
    return matrix;
}

const int ROWS = 4;
const int COLUMNS = 6;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);

Console.WriteLine();

LineOrder(array);
PrintMatrix(array);