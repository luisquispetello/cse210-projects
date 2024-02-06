using System;

class Program
{
  static void Main(string[] args)
  {
    Reference reference = new("Proverb", 3, 16);
    Scripture scripture = new(reference, "Trust in the LORD with all thine heart and lean not unto thine own understanding");


    Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
    Console.WriteLine("");


    while(!scripture.isCompletelyHidden())
    {
      Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
      string userAnswer = Console.ReadLine();

      if(userAnswer == "quit") { break; }

      scripture.HideRandomWords(2);
      Console.Clear();
      Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
    }

  }
}