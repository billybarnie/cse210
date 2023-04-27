class GenPrompt
{
    List<string> prompts;

    public GenPrompt()
    {
        prompts = new List<string>
        {
            "What is your favorite color? ",
            "What is your given name followed by your surname? ",
            "Where are you from? ",
            "What is your favorite kind of food? ",
            "When did you feel thankful that God was in your life? "
        };
    }

    public string GetRandomPrompt()
    {
        int randomIndex = new Random().Next(prompts.Count);
        return prompts[randomIndex];
    }
}