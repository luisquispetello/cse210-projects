using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("White down your grade percentage");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90){
            letter = "A";
        } else if (percentage >= 80){
            letter = "B";
        } else if (percentage >= 70){
            letter = "C";
        } else if (percentage >= 60){
            letter = "D";
        } else{
            letter = "F";
        }

        Console.Write($"Your grade is {letter}. ");

        if (percentage >= 70){
            Console.Write("Congratulations! You pass!");
        } else {
            Console.Write("Keep trying!");
        }

    }
}