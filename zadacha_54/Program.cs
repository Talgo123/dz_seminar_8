// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void OrderArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int h = 0; h < arr.GetLength(1) - 1; h++)
      {
        if (arr[i, h] < arr[i, h + 1])
        {
          int temp = arr[i, h + 1];
          arr[i, h + 1] = arr[i, h];
          arr[i, h] = temp;
        }
      }
    }
  }
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
ShowArray(matrix);
OrderArray (matrix);
System.Console.WriteLine();
ShowArray(matrix);
