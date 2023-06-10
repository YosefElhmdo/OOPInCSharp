namespace Abstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            //         An object cannot be created from a class Abstract
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(3));
            shapes.Add(new Rectangle(4, 4));
            shapes.Add(new Sequer(4));
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.getArea());
                // item.print();
            }
        }
    }
}

