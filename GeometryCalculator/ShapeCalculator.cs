using System;

public class ShapeCalculator
{
    public double Calculate(Shape shape, string calculationType)
    {
        switch (calculationType.ToLower())
        {
            case "çevre":
                return shape.CalculatePerimeter();
            case "alan":
                return shape.CalculateArea();
            case "hacim":
                return shape.CalculateVolume();
            default:
                throw new ArgumentException("Geçersiz hesaplama türü.");
        }
    }
}
