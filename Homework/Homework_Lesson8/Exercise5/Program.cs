/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] matrix = new int[,]      {   {   0, 0, 0, 0  },
                                    {   0, 0, 0, 0  }, 
                                    {   0, 0, 0, 0  },
                                    {   0, 0, 0, 0  }   };

void PrintArray(int[,] matrix)
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

// Метод, спирально заполняющий массив:
int[,] SpiralOrder(int[,] matrix)
{
    for(int number = 1; number <= 6; number++)
    {
        if(number == 1)
        {
            for(int i = 0; i < matrix.GetLength(0)-3; i++)
            {
                int count = 10;
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count; 
                    count++;
                }
            }
        }

        if(number == 2)
        {
            for(int j = 3; j < matrix.GetLength(1); j++)
            {
                int count = 14;
                for(int i = 1; i < matrix.GetLength(0)-1; i++)
                {
                    matrix[i, j] = count;
                    count++; 
                }
            }
        }

        if(number == 3)
        {
            for(int i = 3; i < matrix.GetLength(0); i++)
            {
                int count = 16;
                for(int j = 3; j > matrix.GetLength(1)-5; j--)
                {
                    matrix[i, j] = count; 
                    count++;
                }
            }
        }

        if(number == 4)
        {
            for(int j = 0; j < matrix.GetLength(1)-3; j++)
            {
                int count = 20;
                for(int i = 2; i > matrix.GetLength(0)-4; i--)
                {
                    matrix[i, j] = count;
                    count++; 
                }
            }
        }

        if(number == 5)
        {
            for(int i = 1; i < matrix.GetLength(0)-2; i++)
            {
                int count = 22;
                for(int j = 1; j < matrix.GetLength(1)-1; j++)
                {
                    matrix[i, j] = count; 
                    count++;
                }
            }
        }

        if(number == 6)
        {
            for(int i = 2; i < matrix.GetLength(0)-1; i++)
            {
                int count = 24;
                for(int j = 2; j > matrix.GetLength(1)-4; j--)
                {
                    matrix[i, j] = count; 
                    count++;
                }
            }
        }  
    }     
    return matrix;
}

PrintArray(matrix);
Console.WriteLine();

SpiralOrder(matrix);
PrintArray(matrix);
