using System;

class Program
{
    static void Main(string[] args)
    {
        var array = GetArrayFromConsole(10);
        var sortedarray = SortArray(array);
        ShowArray(array, true);
    }

    static int[] GetArrayFromConsole(int num = 3)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sortedasc = SortArrayDesc(array);
        sorteddesc = SortArrayDesc(array);
    }

    static int[] SortArrayAsc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

        }

        return array;
    }

    static int[] SortArrayDesc(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

        }

        return array;
    }


    static void ShowArray(int[] array, bool sort = false)
    {
        var temp = array;
        if (sort)
        {
            temp = SortArray(array);
        }
        foreach (int item in temp)
        {
            Console.WriteLine(item);
        }
    }
}