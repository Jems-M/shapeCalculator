namespace shapeCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.a = 5; 
            triangle.b = 4;
            triangle.c = 7;

            Console.WriteLine(triangle.getArea());
            
        }
    }
}
