bool IsLeapYear(int year, bool first = true)
{
    if ((year % 400 == 0) && first) return true;
    if ((year % 100 == 0) && first) return false;
    if (year == 0) return true;
    if (year < 0) return false;
    return IsLeapYear(year - 4, false);
}
Console.Clear();
Console.WriteLine("==========Задача № 3==========");
Console.WriteLine("Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет");
int year = 2024;
Console.Write($"{year} год ");
if (!IsLeapYear(year)) Console.Write("НЕ ");
Console.WriteLine("является високосным");
