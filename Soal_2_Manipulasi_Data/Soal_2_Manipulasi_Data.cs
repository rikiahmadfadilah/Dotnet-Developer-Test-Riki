using System;
using System.Collections.Generic;

class Soal_2_Manipulasi_Data
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan elemen array (pisahkan dengan spasi):");
        string input = Console.ReadLine();
        int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.Write("Masukkan nilai target sum: ");
        int targetSum = int.Parse(Console.ReadLine());

        int result = CountPairsWithSum(numbers, targetSum);
        Console.WriteLine($"Jumlah pasangan dengan jumlah {targetSum} adalah: {result}");
    }

    static int CountPairsWithSum(int[] numbers, int targetSum)
    {
        int count = 0;
        Dictionary<int, int> complements = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            int complement = targetSum - number;

            if (complements.ContainsKey(complement))
            {
                count += complements[complement];
            }

            if (complements.ContainsKey(number))
            {
                complements[number]++;
            }
            else
            {
                complements[number] = 1;
            }
        }

        return count;
    }
}
