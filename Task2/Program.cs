// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] SumElemRow(int[,] array)
{
    int[] minRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minRow[i] += array[i, j];
        }
    }
    return minRow;
}

int TrueMinRow(int[] arr)
{
    int minSumm = arr[0];

    int minNumberRow = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSumm)
        {
            minSumm = arr[i];
            minNumberRow = i;
        }
    }
    return minNumberRow;
}



int[,] array2D = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(array2D);

Console.WriteLine(" ");

PrintArray(SumElemRow(array2D));

int[] resultSumm = new int[m]; 
resultSumm = SumElemRow(array2D);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {TrueMinRow(resultSumm) + 1}.");