namespace BoolTable;

public class Negative:Formula
{
    private Formula _formula;

    public Negative(Formula formula)
    {
        _formula = formula;
    }
    public override bool GetValue()
    {
        return !_formula.GetValue();
    }

    public override void Print()
    {
        Console.Write("~");
        _formula.Print();
    }
}