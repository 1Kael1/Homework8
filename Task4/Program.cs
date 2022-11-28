// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)





Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество глубину массива: k=");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (matrix[i, j, k] == 0)
                {
                    int number = rnd.Next(10, 99);
                    if (CheckUniqueElement(matrix, number) == true)
                    {
                        matrix[i, j, k] = number;
                    }
                }
            }
        }
    }
    return matrix;
}
bool CheckUniqueElement(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintCubeMatrix(int[,,] cubeMatr)
{
    for (int i = 0; i < cubeMatr.GetLength(0); i++)
    {
        for (int j = 0; j < cubeMatr.GetLength(1); j++)
        {
            for (int k = 0; k < cubeMatr.GetLength(2); k++)
            {
                Console.Write($"{cubeMatr[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}


if (m * n * z > 99 - 10)
    Console.WriteLine($"Размер массива ({m},{n},{z}) превысил количество уникальных элементов");
else
{
    int[,,] cubeMatrix = CreateMatrixRndInt(m, n, z, 10, 99);
    Console.WriteLine();
    Console.WriteLine($"Размер массива ({m},{n},{z})");
    Console.WriteLine();
    PrintCubeMatrix(cubeMatrix);
    Console.WriteLine();
}
