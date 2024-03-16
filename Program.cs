namespace FactoryMethod
{
    internal class Program
    {
        static void Main()
        {
            var Fabric1 = new RectangleCreator();
            var NewRectangle = Fabric1.Create();
            Fabric1.Info();
            Console.WriteLine(NewRectangle);
            var Fabric2 = new CircleCreator();
            var NewCircle = Fabric2.Create();
            Fabric2.Info();
            Console.WriteLine(NewCircle);
            var Fabric3 = new PointCreator();
            var NewPoint = Fabric3.Create();
            Fabric3.Info();
            Console.WriteLine(NewPoint);
        }
    }

    public interface Shape
    {
        public void ShapeName();
    }

    public class Rectangle : Shape
    {
        public void ShapeName()
        {
            Console.WriteLine("It's Rectangle");
        }
        public override string ToString()
        {
            return "Type Rectangle";
        }
    }

    public class Circle : Shape
    {
        public void ShapeName()
        {
            Console.WriteLine("It's Circle");
        }
        public override string ToString()
        {
            return "Type Circle";
        }
    }

    public class Point : Shape
    {
        public void ShapeName()
        {
            Console.WriteLine("It's Point");
        }
        public override string ToString()
        {
            return "Type Point";
        }
    }

    abstract public class ShapeCreator
    {
        public abstract Shape Create();

        public void Info()
        {
            Console.WriteLine(Create());
        }
    }
    public class RectangleCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Rectangle();
        }
    }
    public class CircleCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Circle();
        }
    }
    public class PointCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Point();
        }
    }
}