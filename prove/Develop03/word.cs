using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(String text)
    {
        _text = text;
        _IsHidden = false;
    }

    public void Hide()
    {
        _IsHidden = true;
    }

    public bool IsHidden()
    {
        return _IsHidden;
    }

    public string GetDisplayText()
    {
        if (_IsHidden)
        {
            return new string('_',_text.Length);
        }
        else
        {
            return _text;
        }
    }
}