using System;

public class Scripture
{
    private List<Word> words;
    private Reference scriptureReference;
    public Scripture(Reference _scriptureReference, string _scripturetxt)
   {
        scriptureReference = _scriptureReference;
        words = new List<Word>();
        CreateWords(_scripturetxt);
   }
    private void CreateWords(string _scripturetxt)
    {
        List<string> totalWords = _scripturetxt.Split(' ').ToList();
        foreach (string item in totalWords)
        {
            Word word = new Word(item);
            words.Add(word);
        }
    }
    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetWord()+" ";
            }
            else 
            {
                scriptureText += new string('*', word.GetWord().Length)+ " ";
            }
        } 
        return ($"{scriptureReference.GetReference()} {scriptureText}");
    }
    public bool HasWordsLeft()
    {
        bool value = false;

        foreach (Word word in words)
        {
            if (word.GetIsHidden()==false)
            {
                value = true;
            }
        }

        return value;
    }
    public void RemoveWords()
    {
        int wordsToDelete = new Random().Next(2, 4);
        int wordDeleted = 0;

        do
        {
            int idx = new Random().Next(0,words.Count());

            if(words[idx].GetIsHidden() == false)
            {
                words[idx].SetisHidden(true);
                wordDeleted++;
            }
        }   while (wordsToDelete != wordDeleted && HasWordsLeft()== true);
    }
}