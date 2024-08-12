using System;

class Soal_1_Logika_Pemrograman
{
    static void Main(string[] args)
    {
        Console.Write("Input angka: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string result = FizzBuzz(number);
            Console.WriteLine($"Hasil: {result}");
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka yang valid.");
        }
    }

    static string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString();
        }
    }

}
