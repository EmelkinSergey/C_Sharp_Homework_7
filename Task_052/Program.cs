// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Задаём двумерный массив размером mхn, заполненный случайными целыми числами
int[,] matrix = new int [3,2];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
// Находим среднее арифметическое элементов в каждом столбце массива
AverageInEachColum(matrix);

// Метод для вывода двумерного массива(матрицы) на экран
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Метод заполнения двумерного масси(матрицы) случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }    
}


// Метод находящий среднее арифметичесое каждого столбца
void AverageInEachColum(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i,j]; 
        }
        double average = sum / matr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j+1}, равно {average:f2}");
    }
}

