const int minValue = 1;
const int maxValue = 100;
const int minSize = 3;
const int maxSize = 20;
void FillArray(int[] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("==========Задача № 1==========");
Console.WriteLine("На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].");
Random random = new Random();
int[] array = new int[random.Next(minSize, maxSize + 1)];
int n = random.Next(minValue, maxValue + 1);
int m = random.Next(minValue, maxValue + 1);
if (n > m) (n, m) = (m, n);
FillArray(array, n, m);
Console.WriteLine($"Массив заполняется значениями от {n} до {m}");
PrintArray(array);