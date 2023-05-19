public class Reflection
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Question> _questionList = new List<Question>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<Question> _questionHistory = new List<Question>();

    public Reflection()
    {
        // Initializing prompts List
        this._promptList.Add(new Prompt("Think of a time when you stood up for someone else."));
        this._promptList.Add(new Prompt("Think of a time when you did something really difficult."));
        this._promptList.Add(new Prompt("Think of a time when you helped someone in need."));
        this._promptList.Add(new Prompt("Think of a time when you did something truly selfless."));

        // Initializing question List
        this._questionList.Add(new Question("Why was this experience meaningful to you?"));
        this._questionList.Add(new Question("Have you ever done anything like this before?"));
        this._questionList.Add(new Question("How did you get started?"));
        this._questionList.Add(new Question("How did you feel when it was complete?"));
        this._questionList.Add(new Question("What made this time different than other times when you were not as successful?"));
        this._questionList.Add(new Question("What is your favorite thing about this experience?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt();

        //Returns the prompt as string.
        return p.GetPrompt(); 
    }

    public string GetRandomQuestion()
    {
        Question q = handleDuplicatedQuestion(); 
        return q.GetQuestion(); 
    }

    private Prompt handleDuplicatedPrompt()
    {
       
        if (this._promptList.Count() == 0)
        {
            Console.WriteLine("We've run out of prompts. You'll start getting repeated ones now.");
            RecyclePromptHistory();
        }

       
        int index = new Random().Next(0, this._promptList.Count() - 1);
        Prompt prompt = this._promptList[index];

        
        this._promptList.Remove(prompt);
        
        this._promptHistory.Add(prompt);

        return prompt;
    }

    private Question handleDuplicatedQuestion()
    {
       
        if (this._questionList.Count() == 0)
        {
            Console.WriteLine("We've ran out of questions. You'll receive repeated questions from now!");
            RecycleQuestionHistory();
        }

        
        int index = new Random().Next(0, this._questionList.Count() - 1);
        Question prompt = this._questionList[index];

        
        this._questionList.Remove(prompt);
        this._questionHistory.Add(prompt);
        return prompt;
    }

    private void RecyclePromptHistory()
    {
        this._promptList.AddRange(this._promptHistory);
        this._promptHistory.Clear();
    }

    private void RecycleQuestionHistory()
    {
        this._questionList.AddRange(this._questionHistory);
        this._questionHistory.Clear();
    }
}