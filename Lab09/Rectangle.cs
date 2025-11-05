namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    // my code, fix lower positions and width/height
    public decimal LowerLeftX { get; }
    public decimal LowerLeftY { get; }
    public decimal Width { get; }
    public decimal Height { get; }
    public Rectangle(decimal lowerLeftX, decimal lowerLeftY, decimal width, decimal height)
    {
        LowerLeftX = lowerLeftX;
        LowerLeftY = lowerLeftY;
        Width = width;
        Height = height;
    }
    // fixed bounds to rectangle (no overlap)
    public override decimal LowerBoundX => LowerLeftX;
    public override decimal UpperBoundX => LowerLeftX + Width;
    public override decimal LowerBoundY => LowerLeftY;
    public override decimal UpperBoundY => LowerLeftY + Height;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return (x >= LowerLeftX && x <= LowerLeftX+Width && y >= LowerLeftY && y <= LowerLeftY+Height);
    }
}