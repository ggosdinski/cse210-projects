using System;

public class Reference
{
    private string book, chapter, versInit, verEnd;
    public Reference(string _book, string _chapter, string _versInit)
    {
        book = _book;
        chapter = _chapter;
        versInit = _versInit;
        verEnd = "";
    }
      public Reference(string _book, string _chapter, string _versInit, string _versEnd)
    {
        book = _book;
        chapter = _chapter;
        versInit = _versInit;
        verEnd = _versEnd;
    }
    public string GetReference()
    {
        if (verEnd == "")
        {
            return($"{book} {chapter}, {versInit}: ");
        }
        else
        {
            return($"{book} {chapter}, {versInit}-{verEnd}: ");
        }
    }
}