// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int SumDiagonalElem(int[,] matr)
{
    int temp = 0;
    for(int i = 0; i < matr.GetLength(0); i ++)
    {
        for(int j = 0; j < matr.GetLength(1); j ++)
        {
            if(i == j)
            {
                temp = temp + matr[i, j];
            }
        }
    }
    return temp;
}


int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 0, 99);
PrintMatrix(matrix);
System.Console.WriteLine(SumDiagonalElem(matrix));

