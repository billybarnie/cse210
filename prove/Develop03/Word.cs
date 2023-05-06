
class Word 
{
    private string word;

    private bool isHidden;

    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }
    
    public bool GetIsHidden()
    {
        return isHidden;
    }

    public void SetIsHidden(bool _hide)
    {
        isHidden = _hide;
    }
    public string GetWord()
    {
        return word;
    }
}