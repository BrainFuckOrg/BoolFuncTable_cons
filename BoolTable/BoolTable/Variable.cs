namespace BoolTable;

public class Variable:Formula
{
    public string Name { get; private set; }
    private bool _currentValue;
    public Variable(string name)
    {
        Name = name;
    }

    public void SetValue(bool value)
    {
        _currentValue = value;
    }
    public override bool GetValue()
    {
        return _currentValue;
    }

    public override void Print()
    {
        Console.Write(Name);
    }
}