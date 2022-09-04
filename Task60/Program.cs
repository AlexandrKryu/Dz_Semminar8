// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j, k],4},");
                else Console.Write($"{matrix[i, j, k],4}");
            }
        }
        Console.WriteLine("]");
    }
}

int[,,] CreateMtrixRnd3d(int x, int y, int z, int min, int max)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(min, max);
            }
        }
    }

    return matrix;
}

void DoubleNumbIn3d(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(0); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(0); k++)
            {
                if (matrix3d[i, j, k] < 100 && matrix3d[i, j, k] > 9)
                    Console.WriteLine($"{matrix3d[i, j, k]} по индексу {i},{j},{k}");
            }
        }
    }
}

int[,,] matrix3d = CreateMtrixRnd3d(5, 5, 5, 10, 999);
PrintMatrix3d(matrix3d);
DoubleNumbIn3d(matrix3d);