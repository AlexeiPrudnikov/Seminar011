const int minValue = 1;
const int maxValue = 10;
const int minSize = 3;
const int maxSize = 7;
const int limitValue = 5;
void FillMatrix(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }    
}
void GetMatrixStatistics(int[,] matrix)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] > limitValue)
            {
                count++;
                sum += matrix[i, j];
            }
        }
    }   
    Console.WriteLine($"Количество элементов, значение которых больше {limitValue} -> {count}");
    Console.WriteLine($"Их сумма -> {sum}");
}
Console.Clear();
Console.WriteLine("=========Задача № 2==========");
Console.WriteLine("Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму");
Random random = new Random();
random.Next(minSize, maxSize + 1);
int[,] matrix = new int[random.Next(minSize, maxSize + 1), random.Next(minSize, maxSize + 1)];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
GetMatrixStatistics(matrix);
