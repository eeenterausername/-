using System;
class Program
{
static string[] FilterShortStrings(string[] arr)
    {
        int count = 0;

        // Подсчитываем количество строк длиной не более 3 символов
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[index] = arr[i];
                index++;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        string[] filteredStrings = FilterShortStrings(strings);

        Console.WriteLine("Строки длиной не более 3 символов:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }

}

