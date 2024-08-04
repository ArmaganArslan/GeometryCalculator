using System;

public class Circle : Shape
{
    private double radius;

    public void GetDimensions()
    {
        Console.WriteLine("Dairenin çapını giriniz:");
        double diameter = Convert.ToDouble(Console.ReadLine());
        radius = diameter / 2;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculateVolume()
    {
        return 0;
    }
}
