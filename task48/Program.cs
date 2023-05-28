// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// rows = 3, cols = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int m, int n)
{
    int[,] Macciv = new int[m, n];
    for (int i = 0; i < Macciv.GetLength(dimension: 0); i++)
    {
        for (int j = 0; j < Macciv.GetLength(dimension: 1); j++)
        {
            Macciv[i, j] = i + j;
        }

    }
    return Macciv;
}

void PrintMatrix(int[,] Macciv)
{
    for (int i = 0; i < Macciv.GetLength(dimension: 0); i++)
    {
        for (int j = 0; j < Macciv.GetLength(dimension: 1); j++)
        {
            System.Console.Write(Macciv[i, j] + " ");
        }
        System.Console.WriteLine();
    }
} 

int[,] Matrix = FillMatrix(ReadInt("Введите количество столбцов: "), ReadInt("Введите количество строк: "));
PrintMatrix(Matrix);