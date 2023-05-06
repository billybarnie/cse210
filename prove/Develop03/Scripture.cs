

class Scripture
{   
    private Reference scriptureRef;

    private List<Word> words;

    public Scripture (Reference _scriptRef, string _scriptText)
    {
        scriptureRef = _scriptRef;
        words = new List<Word>();
        CreateWords(_scriptText);
    }

    public string DisplayScripture()
    {
        string scriptText = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptText += word.GetWord() + " ";
            }
            else
            {
                scriptText += new string('_', word.GetWord().Length) + " ";
            }
        }
        
        return ($"{scriptureRef.GetReference()} {scriptText}");
    }

    public void CreateWords(string _scriptText)
    {                                
        List<string> wholeVerse = _scriptText.Split(" ").ToList();
        foreach (string bit in wholeVerse)
        {
            Word word = new Word(bit);
            words.Add(word);
            
        }

    }

    public bool HasWordsLeft()
    {
        bool refe = false;

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                refe = true;
            }
        }

        return refe;
    }
    public void RemoveWords()
    {
        int removeNumOfWords = new Random().Next(2, 4);
        int removedWords = 0;

        do
        {
            int randomIndex = new Random().Next(0, words.Count());

            if (words[randomIndex].GetIsHidden() == false)
            {
                words[randomIndex].SetIsHidden(true);
                removedWords ++;
            }
        }while (removedWords != removeNumOfWords && this.HasWordsLeft());
    }
}