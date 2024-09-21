using TraiangleApp.Domain;
using TraiangleApp.Services;

try
{
     Console.WriteLine("Enter the lengths of the three sides of the triangle:");

    Console.Write("Side A: ");
    double sideA = double.Parse(Console.ReadLine());

    Console.Write("Side B: ");
    double sideB = double.Parse(Console.ReadLine());

    Console.Write("Side C: ");
    double sideC = double.Parse(Console.ReadLine());

    Triangle triangle = new Triangle(sideA, sideB, sideC);

    TriangleClassifier classifier = new TriangleClassifier();

    string triangleType = classifier.Classify(triangle);
    Console.WriteLine($"The triangle is {triangleType}.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter numeric values.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

