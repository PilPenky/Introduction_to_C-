/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. */

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

int[,] TMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for(int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
        Console.WriteLine();
    }
    return newMatrix;
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);

int[,] matrix2 = TMatrix(array);
PrintMatrix(matrix2);