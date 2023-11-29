using System.Diagnostics;
using TestLibrary;

namespace TestApp1;
internal class Program
{
    static void Main(string[] args)
    {
        Triangle triangle1 = new(3.0, 4.0, 5.0);
        Triangle triangle2 = new(3.2, 4.1, 6.9);
        Triangle triangle3 = new(4.5, 4.5, 4.5);

        Debug.Assert(triangle1.GetTriangleType() is TriangleType.Right);
        Debug.Assert(triangle2.GetTriangleType() is TriangleType.Oblique);
        Debug.Assert(triangle3.GetTriangleType() is TriangleType.Acute);
    }
}
