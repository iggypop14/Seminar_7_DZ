// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Функция генерации массива
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

// Функция приёма значений
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Фнкция распечатки массива
void PrintMatrix(int[,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixFotPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// Функция поиска значения в массиве
void FindItem(int[,] array, int x, int y, int rows_number, int cols_number)
{
    if (x < rows_number && y < cols_number)
    {
        int item = array[x, y];
        System.Console.WriteLine(item);
    }
    else System.Console.WriteLine("Такого элемента не существует");
}
// ------------------------------ Решение ----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int row_position = ReadInt("Введите позицию в строке: ");
int col_position = ReadInt("Введите позицию в столбце: ");

int[,] matrix = FillMatrix(rows, cols, 0, 100);
PrintMatrix(matrix);
FindItem(matrix, row_position, col_position, rows, cols);
