// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int SumElements(int[,] array, int i)
{
    int sumString = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumString += array[i, j];
    }
    return sumString;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNUmber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNUmber("Введите значение M: ");
int n = EnterNUmber("Введите значение N: ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
System.Console.WriteLine();
ShowArray(matrix);
int sumString = SumElements(matrix, 0);
int minSumString = 0;
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int buffer = SumElements(matrix, i);
    if (sumString > buffer)
    {
        sumString = buffer;
        minSumString = i;
    }
}
System.Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов ({sumString}) находится под индексом {minSumString}");
