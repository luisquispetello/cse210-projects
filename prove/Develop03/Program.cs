using System;

class Program
{
  static void Main(string[] args)
  {
    Reference reference = new("Proverb", 3, 16);
    Scripture scripture = new(reference, "Trust in the LORD with all thine heart and lean not unto thine own understanding");

    Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");

    while(!scripture.IsCompletelyHidden())
    {
      Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

      if(Console.ReadLine() == "quit") { break; }
      Console.Clear();

      scripture.HideRandomWords(2);
      Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
    }

  }
}