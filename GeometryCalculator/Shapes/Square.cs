using System;

public class Square : Shape
{
    private double side;

    public void GetDimensions()
    {
        Console.WriteLine("Karenin bir kenar uzunluğunu giriniz:");
        side = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculatePerimeter()
    {
        return 4 * side;
    }

    public double CalculateArea()
    {
        return side * side;
    }

    public double CalculateVolume()
    {
        return 0;
    }
}
