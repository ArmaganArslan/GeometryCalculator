using System;

public class Rectangle : Shape
{
    private double width;
    private double height;

    public void GetDimensions()
    {
        Console.WriteLine("Dikdörtgenin genişliğini giriniz:");
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin yüksekliğini giriniz:");
        height = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height);
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public double CalculateVolume()
    {
        return 0;
    }
}
