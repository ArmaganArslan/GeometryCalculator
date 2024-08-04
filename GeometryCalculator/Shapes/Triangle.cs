using System;

public class Triangle : Shape
{
    private double sideA;
    private double sideB;
    private double sideC;

    public void GetDimensions()
    {
        Console.WriteLine("Üçgenin üç kenarını giriniz:");
        sideA = Convert.ToDouble(Console.ReadLine());
        sideB = Convert.ToDouble(Console.ReadLine());
        sideC = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }

    public double CalculateArea()
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public double CalculateVolume()
    {
        return 0;
    }
}
