using System;

namespace Lab2
{
    public interface IPrint
    {
        void Print();
    }

    public abstract class Figure : IPrint
    {
        public abstract double Area();

        public void Print() =>
            Console.WriteLine(ToString());
    }

    public class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double heigth, double width) =>
            (Height, Width) = (heigth, width);

        public override double Area() =>
            Height * Width;

        public override string ToString() => 
            $"Прямоугольник:\nШирина: {Width}; Высота: {Height}; Площадь: {Area()}";
    }

    public class Square : Rectangle
    {
        public Square(double a) : base(a, a) { }

        public override string ToString() =>
            $"Квадрат:\nДлина стороны: {Width}; Площадь: {Area()}";
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) =>
            Radius = radius;

        public override double Area() =>
            Math.PI * Radius * Radius;

        public override string ToString() =>
            $"Круг:\nРадиус: {Radius}; Площадь: {Area()}";

        public static class Program
        {
            public static void Main()
            {
                var circle = new Circle(3d);
                circle.Print();

                var square = new Square(2d);
                square.Print();

                var rectangle = new Rectangle(1d, 3d);
                rectangle.Print();
            }
        }
    }
}
