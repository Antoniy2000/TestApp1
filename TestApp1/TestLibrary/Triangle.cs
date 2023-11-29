namespace TestLibrary;
public class Triangle
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public Triangle(double a, double b, double c)
    {
        if (!(a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0))
        {
            throw new ArgumentException();
        }
        A = a; 
        B = b; 
        C = c;
    }
    public TriangleType GetTriangleType()
    {
        if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
        {
            return TriangleType.Right;
        }
        else if ((A * A > B * B + C * C) || (B * B > A * A + C * C) || (C * C > A * A + B * B))
        {
            return TriangleType.Oblique;
        }
        else
        {
            return TriangleType.Acute;
        }
    }
}
