namespace Imheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double perimeter = circle.GetPerimeter();
            double area = circle.GetArea();
            Console.WriteLine(perimeter + " m^2");
            Console.WriteLine(area + " m^2");
            Cylinder cylinder = new Cylinder(5, 10);
            double volume = cylinder.GetVolume();
            Console.WriteLine(volume + " m^2");
            Circle circle1 = new Circle(8);
            double p = circle1.Radius;
            Console.WriteLine(p);
            Cylinder cylinder1 = new Cylinder(10, 5);
            double c = cylinder1.Height;
            double m = cylinder1.Radius;
            Console.WriteLine(c);
            Console.WriteLine(m);
            Weel w = new Weel("lkjhgf", 6, 6.5);
            w.printData();
        }
    }
    class Circle
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
            Console.WriteLine(" Circle");
        }
        public double Radius { get; set; }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    class Cylinder : Circle
    {
        public Cylinder(double Height, double r) : base(r)
        {
            this.Height = Height;
            Console.WriteLine(" Cylinder");
            Console.WriteLine(GetPerimeter());
            Console.WriteLine(GetArea());
        }
        public double Height { get; set; }
        public double GetArea()
        {
            return GetPerimeter() + 2 * base.GetArea();
        }
        public double GetVolume()
        {
            return base.GetArea() * Height;
        }
    }
    class Weel : Cylinder
    {
        public Weel(string t, double Height, double r) : base(Height, r)
        {
            type = t;
        }
        public string type { get; set; }
        public void printData()
        {
            Console.WriteLine(base.Radius);
            Console.WriteLine(base.Height);
            Console.WriteLine(this.type);
        }
    }
}