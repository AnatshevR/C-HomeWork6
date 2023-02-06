// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(int [,] matr)
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

void FillArray(int [,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j; 
        }
    }
}

void ChangeElement(int [,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ( i%2==0 && j%2==0)
            {
                matr[i, j] = matr[i, j] * matr[i, j];
            }
            else
            {
                matr[i, j] = matr[i, j];
            }
        }
    }
}


Console.Write("enter amount of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in array: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeElement(matrix);
PrintArray(matrix);

