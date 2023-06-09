
class Proverbs
{
    List<string> bookOfProverbs = System.IO.File.ReadAllLines("Proverbs.csv").ToList();
    private string randomVerse;

    public Proverbs()
    {
        randomVerse = GetVerse();
    }

    private string GetVerse()
    {
        int randomIndex = new Random().Next(bookOfProverbs.Count);
        return bookOfProverbs[randomIndex];
    }
    List<string> SplitList()
    {
        List<string> elements = new List<string>();
        if (randomVerse.Contains('"'))
        {
            string[] separateScripture = randomVerse.Split('"');

            elements = separateScripture[0].Split(',').ToList<string>();

            elements.Add(separateScripture[1]);
        }
        else
        {
            elements = randomVerse.Split(',').ToList();
        }

        return elements;
    }

    public (string, string, string, string) ProverbElement()
    {
        List<string> ListOfProverbs = SplitList();
        string _book = ListOfProverbs[0];
        string _chapter = ListOfProverbs[1];
        string _verse = ListOfProverbs[2];
        string _text;

        if (ListOfProverbs[3] == "")
        {
            _text = ListOfProverbs[4];
        }
        else
        {
            _text = ListOfProverbs[3];
        }
        

        return (_book, _chapter, _verse, _text);
    }
    
}

