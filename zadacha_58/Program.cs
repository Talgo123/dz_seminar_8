// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int cr = 0; cr < firstMatrix.GetLength(1); cr++)
            {
                sum += firstMatrix[i, cr] * secondMatrix[cr, j];
            }
            resultMatrix[i,j] = sum;
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

int m = EnterNUmber("Введите кол-во строк в первой матрице: ");
int n = EnterNUmber("Введите кол-во столбцов в первой матрице и кол-во строк во второй матрице (одной цифрой): ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
int c = EnterNUmber("Введите колв-во столбцов во второй матрице: ");
int[,] matrixTwo = CreateRandomArray(n, c, 1, 10);
ShowArray(matrix);
System.Console.WriteLine();
ShowArray(matrixTwo);
int[,] resultMatrix = new int[m,c];

MultiplicationMatrix(matrix, matrixTwo, resultMatrix);
System.Console.WriteLine("Произведением первой и второй матрицы является ");
ShowArray(resultMatrix);
