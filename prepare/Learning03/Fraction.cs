using System;
class Fraction
{
    private int top;
    private int bottom;

    public Fraction() {
        this.top = 1;
        this.bottom = 1;
    }
    public Fraction(int top) {
        this.top = top;
        this.bottom = 1;
    }
    public Fraction(int top, int bottom) {
        this.top = top;
        this.bottom = bottom;
    }

    public int GetTop() {
        return top;
    }
    public int GetBottom() {
        return bottom;
    }
    public void SetTop(int input) {
        top = input;
    }
    public void SetBottom(int input) {
        bottom = input;
    }

    public string GetFractionString() {
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue() {
        return ((double)top)/((double)bottom);
    }

}