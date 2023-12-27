// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

{
        // Задаем произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("\nМассив, выведенный с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }