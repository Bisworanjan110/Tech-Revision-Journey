namespace ShapePolymorphisism
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape. . .");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle. . .");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle. . .");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            shape.Draw();
            circle.Draw();
            rectangle.Draw();
        }
    }
}
