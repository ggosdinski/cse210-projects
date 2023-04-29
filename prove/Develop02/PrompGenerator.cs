using System; 

public class Prompt
{
    public List<string>_prompts; 
    public Prompt()
    // This is the constructor used to store the prompts
    {
        _prompts = new List<string> () 
        {
        "What things should you feel grateful for today?",
        "What made you laugh the most today?",
        "If you had the chance to do something you did today again, what would it be and what would you change?",
        "What was the strongest emotion you felt today?",
        "How could you feel Heavenly Father's love today?",
        "What things can you do better tomorrow than today?",
        };
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return (_prompts[index]);
    }
}