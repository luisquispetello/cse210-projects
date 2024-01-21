using System;

class Program
{
    static void Main(string[] args){
        DisplayWelcomeMessage();
        string name = AskName();
        int num = AskNum();
        int square = num * num;
        Response(name, square);
    }
    static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to the program");
    }

    static string AskName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int AskNum() {
        Console.Write("Please enter your favortie number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void Response(string name, int num){
        Console.WriteLine($"Brother {name}, the square of your number is: {num}");
    }
}