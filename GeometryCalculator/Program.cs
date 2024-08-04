using System;

class Program
{
    static void Main(string[] args)
    {
        ShapeCalculator calculator = new ShapeCalculator();

        Console.WriteLine("Hangi geometrik şekil ile işlem yapmak istiyorsunuz? (Daire, Üçgen, Kare, Dikdörtgen):");
        string shapeType = Console.ReadLine();

        Shape shape = ShapeFactory.CreateShape(shapeType);
        if (shape == null)
        {
            Console.WriteLine("Geçersiz şekil türü.");
            return;
        }

        shape.GetDimensions();

        Console.WriteLine("Hangi hesaplamayı yapmak istiyorsunuz? (Çevre, Alan, Hacim):");
        string calculationType = Console.ReadLine();

        double result = calculator.Calculate(shape, calculationType);

        Console.WriteLine($"Sonuç: {result}");

        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }
}
