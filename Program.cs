
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