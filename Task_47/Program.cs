// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количетсво строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);
PamArray(array);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
}

void PamArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{Math.Round(array[i, j], 2),5}\t");
        Console.WriteLine();
    }
}