class Program
{
    static void Main(string[] args)
    {
       Reference reference = new Reference("1 Nephi", "Chapter 3", "Verse 7");

       Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

       string userInput= "";
       while (userInput != "quit" && scripture.HasWordsLeft() == true)
       {
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();
        Console.WriteLine("Please, PRESS enter to continue or TYPE 'quit' to finish:");
        userInput = Console.ReadLine();
        scripture.RemoveWords();
       }

    }
}