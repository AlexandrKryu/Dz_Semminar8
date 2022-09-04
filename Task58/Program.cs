// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:


// int Rows()
// {
//     while (true)
//     {
//         try
//         {
//             Console.Write("Введите количество строк: ");
//             int mTmp = int.Parse(Console.ReadLine()!);

//             if (mTmp <= 0)
//             {
//                 Console.WriteLine("Пожалуйста, введите значение больше нуля!");
//                 Console.WriteLine();
//                 continue;
//             }
//             else return mTmp;
//         }
//         catch
//         {
//             Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
//             Console.WriteLine();
//             continue;
//         }
//     }
// }

// int Colums()

// {
//     while (true)
//     {
//         try
//         {
//             Console.Write("Введите количество столбцов: ");
//             int nTmp = int.Parse(Console.ReadLine()!);

//             if (nTmp <= 0)
//             {
//                 Console.WriteLine("Пожалуйста, введите значение больше нуля!");
//                 Console.WriteLine();
//                 continue;
//             }
//             else return nTmp;
//         }
//         catch
//         {
//             Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
//             Console.WriteLine();
//             continue;
//         }
//     }
// }

// int row = Rows();

// int col = Colums();

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}


int[,] MultipliersTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int multip = 0;

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine();
        Console.WriteLine("Условия не соблюдены");
    }
    else
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    multip += matrix1[i, k] * matrix2[k, j];
                }
                matrix3[i, j] = multip;
                multip = 0;
            }
        }
    }
    return matrix3;
}

int[,] matrix1 = CreateMtrixRndInt(4, 3, 1, 9);
int[,] matrix2 = CreateMtrixRndInt(3, 5, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] matrix3 = MultipliersTwoMatrix(matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrix3);