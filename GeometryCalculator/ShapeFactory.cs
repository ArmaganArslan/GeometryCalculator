public static class ShapeFactory
{
    public static Shape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "daire":
                return new Circle();
            case "üçgen":
                return new Triangle();
            case "kare":
                return new Square();
            case "dikdörtgen":
                return new Rectangle();
            default:
                return null;
        }
    }
}
