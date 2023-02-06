public static class Sorting
{
    public static int[] SelectionSort(this int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < size; j++)
            {
                if (collection[j] < collection[pos]) pos = j;
            }
            int temp = collection[i];
            collection[i] = collection[pos];
            collection[pos] = temp;
        }
        return collection;
    }

    public static int[] SortQuick(this int[] collection, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = collection[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;

            if (i <= j)
            {
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }
        }
        if (i < right) SortQuick(collection, i, right);
        if (left < j) SortQuick(collection, left, j);
        return collection;
    }
    
    public static int[] BoobleTipeSort(this int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - 1 - i; j++)
            {
                if (collection[j] > collection[j + 1]) 
                {
                    int temp = collection[j];
                    collection[j] = collection[j + 1];
                    collection[j + 1] = temp;
                }
            }
            //System.Console.Write($"{i}: {string.Join(", ", collection)}");
            //System.Console.WriteLine();
        }
        return collection;
    }
}