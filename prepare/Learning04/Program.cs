using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new("Luis", "Programing");
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new("Luis", "Programming", "8", "1-7");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WrittingAssignment writingAssignment = new("Luis", "Programming", "c#");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}