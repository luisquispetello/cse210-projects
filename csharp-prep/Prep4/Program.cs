using System;
using System.Formats.Asn1;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        int answer = -1;
        int sum = 0;
        int maxNum = 0;

        while (answer != 0) {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");

            Console.Write("Enter number: ");
            answer = int.Parse(Console.ReadLine());

            if (answer != 0) {
                numbers.Add(answer);10
            }
        }

        foreach (int num in numbers) {
            sum += num;
            if (num > maxNum) {
                maxNum = num;
            }
        }

        int average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}