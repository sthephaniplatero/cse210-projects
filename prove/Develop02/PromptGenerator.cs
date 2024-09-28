using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was your favorite person you talk with and why?",
        "Would you like to did something better today?",
        "What was a enjoyable moment for you today?",
        "Why you are greatful for today?",
        "What was the funniest event for you today?",
        ""
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
