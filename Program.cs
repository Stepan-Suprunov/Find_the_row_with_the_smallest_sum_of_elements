//Найти строку с наименьшей суммой элементов


void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(-99, 100);
        }
    }
}

void CompareSum(int[,] collection)
{
    int[] sums = new int[collection.GetLength(0)];

    for (int i = 0; i < collection.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            sum += collection[i, j];
        }
        sums[i] = sum;
    }

    int minIndex = 0;
    int minNumber = sums[0];
    for (int i = 0; i < sums.Length; i++)
    {
        if (sums[i] < minNumber)
        {
            minIndex = i;
            minNumber = sums[i];
        }
    }
    
    Console.WriteLine("Сумма элементов в строке №" + (minIndex +1) + " равна " + sums[minIndex] + " и является наименьшей среди сумм элементов других строк");
}



int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
CompareSum(array);