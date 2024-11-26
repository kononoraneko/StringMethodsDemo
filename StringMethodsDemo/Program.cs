using System;

class StringMethodsDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Введите вторую строку:");
        string str2 = Console.ReadLine();

        Console.WriteLine($"\nРезультат Compare: {string.Compare(str1, str2)}");
        Console.WriteLine("(-1, если первая строка по алфавиту стоит меньше второй, 1, если наоборот. 0 - если строки равны)\n");

        Console.WriteLine($"Результат Equals: {string.Equals(str1, str2)}\n");

        Console.WriteLine($"Результат CompareOrdinal: {string.CompareOrdinal(str1, str2)}");
        Console.WriteLine("(Сравнивает строки быстрее, т.к. сравнивает побайтовые значения символов, игнорируя региональные настройки.)\n");


        Console.WriteLine("Введите символ для поиска: ");
        char char1 = Console.ReadLine()[0];
        Console.WriteLine($"Результат IndexOf для 1й строки: {str1.IndexOf(char1)}");
        Console.WriteLine($"Результат IndexOf для 2й строки: {str2.IndexOf(char1)}\n");

        Console.WriteLine("Введите подстроку для поиска");
        string subStr = Console.ReadLine();
        Console.WriteLine($"Результат Contains для 1й строки: {str1.Contains(subStr)}\n");
        Console.WriteLine($"Результат Contains для 2й строки: {str2.Contains(subStr)}\n");

        Console.WriteLine($"\n{str1} == {str2} - {str1 == str2}");
        Console.WriteLine($"\n{str1} != {str2} - {str1 != str2}");
    }
}
