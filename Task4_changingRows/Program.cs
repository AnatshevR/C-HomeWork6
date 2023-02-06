// Написать программу, которая обменивает элементы первой строки и последней строки

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
            if ( i==0)
            {
                int tempo = matr[i, j];
                matr[i, j] = matr [matr.GetLength(0)-1,j];
                matr [matr.GetLength(0)-1,j] = tempo;
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
