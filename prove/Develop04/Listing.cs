public class Listing
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<string> _answersByPrompt = new List<string>();

    public Listing()
    {
        this._promptList.Add(new Prompt("Who are people that you appreciate?"));
        this._promptList.Add(new Prompt("What are personal strengths of yours?"));
        this._promptList.Add(new Prompt("Who are people that you have helped this week?"));
        this._promptList.Add(new Prompt("When have you felt the Holy Ghost this month?"));
        this._promptList.Add(new Prompt("Who are some of your personal heroes?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt(); 
        return p.GetPrompt(); 
    }

    public void SaveAnswer(string q)
    {
        this._answersByPrompt.Add(q);
    }

    public int AnswersByPromptSize()
    {
        return this._answersByPrompt.Count();
    }

    private Prompt handleDuplicatedPrompt()
    {
        if (this._promptList.Count() == 0)
        {
            Console.WriteLine("We've run out of prompts. You'll start getting repeated ones now.");
            RecycleHistory();
        }

        int index = new Random().Next(0, this._promptList.Count() - 1);
        Prompt prompt = this._promptList[index];


        this._promptList.Remove(prompt);
        this._promptHistory.Add(prompt);

        return prompt;
    }

    private void RecycleHistory()
    {
        
        this._promptList.AddRange(this._promptHistory);
        this._promptHistory.Clear();
    }
}