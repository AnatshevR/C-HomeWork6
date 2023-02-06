//Показать двумерный массив размером m×n заполненный вещественными числами


void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(random.Next(10) + random.NextDouble (), 3 ); 
        }
    }
}

Console.Write("enter amount of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in array: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[rows, columns];

FillArray(matrix);
PrintArray(matrix);

