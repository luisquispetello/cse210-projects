
public class Scripture
{
  private Reference _reference;
  private List<Word> _words;


  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(word => new Word(word)).ToList();

    // 👇 This code below can be used instead of the one line code avobe.
    // string[] wordsArray = text.Split(' ');
    // foreach(string word in wordsArray)
    // {
    //   _words.Add(new Word(word));
    // }
  }


  public void HideRandomWords(int numberToHide)
  {
    Random random = new();

    for (int i = 0; i < numberToHide; i++)
    {
      int index = random.Next(_words.Count);
      _words[index].Hide();
    }
  }

  public string GetDisplayText()
  {
    return string.Join(' ', _words);
  }

  public bool isCompletelyHidden()
  {
    return _words.All(word => word.isHidden());

    // 👇 This code below can be used instead of the one line code avobe.
    // foreach (Word word in _words)
    // {
    //   if(!word.isHidden()) { return false; }
    // }
    // return true;
  }
}