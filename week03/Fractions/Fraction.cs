using System;

public class Fraction
{
    private int _topN;
    private int _botN;

    public Fraction()
    {
        _topN = 1;
        _botN = 1;
    }

    public Fraction(int topN)
    {
        _topN = topN;
        _botN = 1;
    }
    public Fraction(int topN, int botN)
    {
        _topN = topN;
        _botN = botN;
    }

    public int getTopN()
    {
        return _topN;
    }
    public int getBotN()
    {
        return _botN;
    }

    public string GetFractionString()
    {
        string text = $"{_topN}/{_botN}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topN / (double)_botN;
    }

}