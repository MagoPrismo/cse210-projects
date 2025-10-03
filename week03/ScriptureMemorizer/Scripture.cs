public class Scripture
{
    //to show creativity, my program will not try to hide an already hidden word
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string verse)
    {
        _reference = reference;
        List<string> _wordList = new List<string>(verse.Split(' '));

        foreach (string word in _wordList)
        {
            Word x = new Word(word);
            _words.Add(x);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public void HideRandomWords(int numb)
    {
        Random randint = new Random();
        List<Word> available = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                available.Add(word);
            }
        }
        for (int i = 0; i < numb && available.Count > 0; i++)
        {
            int index = randint.Next(available.Count);
            available[index].Hide();
            available.RemoveAt(index);
        }
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}