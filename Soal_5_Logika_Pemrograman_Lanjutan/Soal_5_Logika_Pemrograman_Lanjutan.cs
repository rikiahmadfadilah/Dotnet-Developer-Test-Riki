using System;
using System.Linq;

class Soal_5_Logika_Pemrograman_Lanjutan
{
    static void Main(string[] args)
    {
        PalindromeChecker checker = new PalindromeChecker();

        Console.Write("Masukkan sebuah string: ");
        string input = Console.ReadLine();

        bool isPalindrome = checker.IsPalindrome(input);
        Console.WriteLine(isPalindrome ? "String tersebut adalah palindrome." : "String tersebut bukan palindrome.");
    }
}

public class PalindromeChecker
{
    public bool IsPalindrome(string input)
    {
        string filteredInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        int left = 0;
        int right = filteredInput.Length - 1;

        while (left < right)
        {
            if (filteredInput[left] != filteredInput[right])
            {
                return false;
            }
            left++;
            right--;
        }

        // cara cepat bisa menggunakan fungsi Reverse()

        return true;
    }
}
