using System;

public class MathAssignment: Assignment
{
    private string _texbookSection = "";
    private string _problems = "";
    public MathAssignment(string textbook, string problems, string name, string topic):base(name, topic)
    {
        _texbookSection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_texbookSection}, Problems: {_problems}";
    }
}