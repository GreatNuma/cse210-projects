using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() => _isHidden = true;

    public void Show() => _isHidden = false;

    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Retain punctuation marks if they exist at the end of a word
            char lastChar = _text[^1];
            if (char.IsPunctuation(lastChar))
            {
                return new string('_', _text.Length - 1) + lastChar;
            }
            return new string('_', _text.Length);
        }
        return _text;
    }
}