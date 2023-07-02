// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ---------------------------- Задание функций ---------------------------------------

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

// Функция нахождения среднего арифметического в стобце
void FindMean(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int col_sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            col_sum += array[j, i];
            //System.Console.WriteLine($"Среднее арифметическо столбца {j} равно {col_sum / array.GetLength(1)}");
        }
        System.Console.WriteLine($"Среднее арифметическое столбца {i} равно: {col_sum / array.GetLength(0)}");
        //System.Console.WriteLine("\n");
    }
    //return tempMatrix;
}




// ------------------------------ Решение ----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
//int row_position = ReadInt("Введите позицию в строке: ");
//int col_position = ReadInt("Введите позицию в столбце: ");

int[,] matrix = FillMatrix(rows, cols, 0, 50);
System.Console.WriteLine("\nВывод массива: ");
PrintMatrix(matrix);
System.Console.WriteLine("\nВывод средних арифметических значений каждого столбца: ");
FindMean(matrix);


