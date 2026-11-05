using System;

public class Prompt
{
    public List<string> _prompts = new List<string>(
        ["Who was the most interesting person I interacted with today?", // 0
         "What was the best part of my day?", // 1
          "How did I see the hand of the Lord in my life today?", // 2
          "What was the strongest emotion I felt today?",// 3
          "If I had one thing I could do over today; what would it be?"] // 4
    );

    // public void AddPromptToList()
    // {

    // }

    public string RandomPrompt()
    {
        int size = _prompts.Count;
        Random random = new Random();
        int randomPromt = random.Next(0, size);
        Console.WriteLine(_prompts[randomPromt]);
        return _prompts[randomPromt];
    }
}