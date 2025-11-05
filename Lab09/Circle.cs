namespace Lab09;

public class Circle : AbstractGraphic2D
{
    // my code I added
    public decimal CenterX { get; }
    public decimal CenterY { get; }
    public decimal Radius { get; }
    public Circle(decimal centerX, decimal centerY, decimal radius)
    {
        CenterX = centerX;
        CenterY = centerY;
        Radius = radius;
    }
    // fixed bounds to circle (no overlap)
    public override decimal LowerBoundX => CenterX - Radius;
    public override decimal UpperBoundX => CenterX + Radius;
    public override decimal LowerBoundY => CenterY - Radius;
    public override decimal UpperBoundY => CenterY + Radius;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        // fixed bool, gives edges and finds radius
        decimal dx = x - CenterX;
        decimal dy = y - CenterY;
        decimal cSquared = dx * dx + dy * dy;
        return cSquared <= Radius * Radius;
    }
}