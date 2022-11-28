// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1ого массива: m1=");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 1ого массива: n1=");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2ого массива: m2=");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2ого массива: n2=");
int n2 = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Произведение матриц невозможно");
    }

    int[,] matrixMulty = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int x = 0; x < firstMatrix.GetLength(1); x++)
                {
                    matrixMulty[i, j] += firstMatrix[i, x] * secondMatrix[x, j];
                }
            }
        }
        Console.WriteLine("Результат произведения двух матриц: ");
        Console.WriteLine("");
        PrintMatrix(matrixMulty);
    }
}
    int[,] array2D = CreateMatrixRndInt(m1, n1, -9, 9);
    int[,] array2D2 = CreateMatrixRndInt2(m2, n2, -9, 9);
    PrintMatrix(array2D);
    Console.WriteLine("            X");
    PrintMatrix(array2D2);
    MultiplicationMatrix(array2D, array2D2);