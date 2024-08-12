using System;


class Soal_5_Logika_Pemrograman_Lanjutan
{
    static void Main(string[] args)
    {
        ArrayMerger merger = new ArrayMerger();

        int[] array1 = { 1, 3, 5, 7 };
        int[] array2 = { 2, 4, 6, 8 };

        int[] mergedArray = merger.MergeSortedArrays(array1, array2);

        Console.WriteLine("Array yang sudah digabung dan diurutkan:");
        Console.WriteLine(string.Join(", ", mergedArray));
    }
}

public class ArrayMerger
{
    public int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] <= array2[j])
            {
                mergedArray[k++] = array1[i++];
            }
            else
            {
                mergedArray[k++] = array2[j++];
            }
        }

        while (i < array1.Length)
        {
            mergedArray[k++] = array1[i++];
        }

        while (j < array2.Length)
        {
            mergedArray[k++] = array2[j++];
        }

        return mergedArray;
    }
}
