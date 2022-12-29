// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введие количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindNumber(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(1, 100);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FindNumber(int[,] array)
{
    int posx = 0;
    int posy = 0;
    bool check = false;
    Console.WriteLine("Введие искомое число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == number)
            {
                posy = i;
                posx = j;
                Console.WriteLine($"Положение в массиве элемента {number} находится в cтроке {posy + 1} и столбце {posx + 1} ");
                check = true;
            }
    if (check == false)Console.WriteLine("Такого числа в матрице нет");
}

