using System.Collections.Generic;
public class Scripture
{
  private Reference _reference;
  private List<Word> _words;


  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(word => new Word(word)).ToList();

    // 👇 Code below can be used instead of the code above
    // _words = new();
    // string[] wordsArray = text.Split(' ');
    // foreach (string word in wordsArray)
    // {
    //   _words.Add(new Word(word));
    // }
  }


  public void HideRandomWords(int numberToHide)
  {
    List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
    Random random = new();
    int index = random.Next(visibleWords.Count);

    if (visibleWords.Count > 0)
    {
      for (int i = 0; i < numberToHide; i++)
      {
        visibleWords[index].Hide();
      }
    }

  }

  public string GetDisplayText()
  {
    List<string> displayWords = new();
    foreach (Word word in _words)
    {
      displayWords.Add(word.GetDisplayText());
    }
    return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(word => word.IsHidden());
  }
}