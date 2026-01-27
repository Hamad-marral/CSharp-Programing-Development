class Circle(int radius)
{
    readonly float _PI = 3.14f;
    readonly int _Radius = radius;
    
    public float CalculateArea()
    {
        return _PI * _Radius * _Radius;
    }
}


class Program
{
    public static void Main()
    {
        Circle c1 = new(5);
        float area = c1.CalculateArea();
        Console.WriteLine("Area of Circle: {0}", area);

        Circle c2 = new(10);
        float area2 = c2.CalculateArea();
        Console.WriteLine("Area of Circle: {0}", area2);
    }

}