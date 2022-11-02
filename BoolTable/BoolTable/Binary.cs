using System.Diagnostics;

namespace BoolTable;

public class Binary:Formula
{
    private Formula _formula1, _formula2;
    public enum BinaryOperator
    {
        And,
        Or,
        Xor,
        IfThen
    }
    public BinaryOperator CurrentOperator { get; private set; }
    public Binary(Formula formula1, Formula formula2,BinaryOperator currentOperator)
    {
        _formula1 = formula1;
        _formula2 = formula2;
        CurrentOperator = currentOperator;
    }

    public override bool GetValue()
    {
        return CurrentOperator switch
        {
            BinaryOperator.And => _formula1.GetValue() & _formula2.GetValue(),
            BinaryOperator.Or => _formula1.GetValue() | _formula2.GetValue(),
            BinaryOperator.Xor => _formula1.GetValue() ^ _formula2.GetValue(),
            BinaryOperator.IfThen => !_formula1.GetValue() | _formula2.GetValue()
        };
    }
    public override void Print()
    {
        Console.Write("(");
        _formula1.Print();
        Console.Write(CurrentOperator switch {
            BinaryOperator.And=>"∩",
            BinaryOperator.Or=>"∪",
            BinaryOperator.Xor=>"⊕",
            BinaryOperator.IfThen=>"→"
        });
        _formula2.Print();
        Console.Write(")");
    }
}