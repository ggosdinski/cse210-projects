using System;

public class Fraction
{
   private int _topNumber;
   private int _bottomNumber;

   public Fraction()
   {
    _topNumber = 1;
    _bottomNumber = 1;
   }

    public Fraction(int top)
   {
    _topNumber = top;
    _bottomNumber = 1;
   }

    public Fraction(int top, int bottom)
   {
    _topNumber = top;
    _bottomNumber = bottom;
   }

    public string GetFractionString()
    {
        string txt = $"{_topNumber}/{_bottomNumber}";
        return txt;
    }

    public double GetDecimalValue()
    {
        return (double) _topNumber/ (double)_bottomNumber;
    }
}