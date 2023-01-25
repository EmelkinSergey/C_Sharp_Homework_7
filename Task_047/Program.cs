// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
double [,] matrix = new double [4,5];
PrintArray(matrix);
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
 // Метод для вывода двумерного массива(матрицы) на экран
void PrintArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]:f1}  ");
        }
        Console.WriteLine();
    }
}

// Метод заполнения двумерного масси(матрицы) случайными числами
void FillArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble() * new Random().Next(-10,10);
        }  
    }  
}

