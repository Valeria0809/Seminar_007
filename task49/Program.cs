// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void Task49()
{
    int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 2, 9);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    Transform(matrix);

    PrintMatrix(matrix);
}

void Transform(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i += 2)
    {
        for (int j = 1; j < matr.GetLength(1); j += 2)
        {
            // matrix[i, j] = matrix[i, j] * matrix[i, j];
            matr[i, j] = (int)Math.Pow(matr[i, j], 2);
        }
    }
}
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix


