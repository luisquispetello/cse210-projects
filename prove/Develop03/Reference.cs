public class Reference
{
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endVerse;
  // private string _display;


  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    // _display = $"{_book} {_chapter}:{_verse}";
  }

  public Reference(string book, int chapter, int verse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = endVerse;
    // _display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
  }


  public string GetDisplayText()
  {
    return $"{_book} {_chapter}:{_verse}";
  }
}
