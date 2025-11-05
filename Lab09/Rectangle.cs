namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}