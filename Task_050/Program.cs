// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки");
int I = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int J = Convert.ToInt32(Console.ReadLine());

// Задаём двумерный массив размером mхn, заполненный случайными целыми числами
int[,] matrix = new int [4,5];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

// Находим значение элемента массива по строке и столбцу от пользователя
FindNum(matrix, I, J);

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

// Метод выводящий значение из массива по введённым данным пользователя строки и столбца

void FindNum(int[,] matr, int A, int B)
{
    if ( (A-1) <= matr.GetLength(0) & (B-1) <= matr.GetLength(1))
    {
        Console.WriteLine($"Значение элемента двумерного массива в {A} строке {B} столбца, равно {matr[(A-1), (B-1)]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента в массиве не существует");
    }
}