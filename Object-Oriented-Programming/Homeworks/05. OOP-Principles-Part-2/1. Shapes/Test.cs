namespace Shapes
{
    public class Test
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[]
                {
                    new Square(2.5),
                    new Triangle(5, 3.53),
                    new Rectangle(4, 5),
                 // new Square(0),          "ArgumentOutOfRangeException"
                    new Rectangle(111.1, 1),
                    new Triangle(0.1, 100)
                };

            foreach (Shape shape in shapes)
            {
                System.Console.WriteLine(shape);                
            }
        }
    }
}
