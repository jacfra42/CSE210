public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
            {
                int j = rand.Next(_words.Count);
                _words[j].Hide();
            }
    }
    public string GetDisplayText()
    {
        string textWithHidden = "";
        foreach (Word word in _words)
        {
            textWithHidden += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {textWithHidden}";
    }
    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}