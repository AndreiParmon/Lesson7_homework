// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10)
{
    int[,] matr = new int [rows, columns];
    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine("Ведите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());
if((m > rowsCount-1) || (n > columnsCount-1))
    {
        Console.WriteLine("Такого числа в массиве нет!");
    }
else
    {
        object? arr = matrix.GetValue(m, n);
        Console.WriteLine(arr);
    }