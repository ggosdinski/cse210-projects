using System;

public class Word
{
    private string word;
    private bool isHidden;
    public Word(string _word)
    {
        word = _word;
    }

    public bool GetIsHidden()
    {
        return isHidden;
    }

    public void SetisHidden(bool _isHidden)
    {
        isHidden = _isHidden;
    }

    public string GetWord()
    {
        return word;
    }
}