using System;
using Lab2;
using System.Collections;
using System.Collections.Generic;

namespace Lab3
{
    public static class Program
    {
        public static void Main()
        {
            var square = new Square(2d);
            var rectangle = new Rectangle(1d, 2d);
            var circle = new Circle(1d);

            var array = new ArrayList
            {
                square,
                rectangle,
                circle
            };

            array.Sort();

            foreach (Figure figure in array)
                figure.Print();

            var list = new List<Figure>
            {
                square,
                rectangle,
                circle
            };

            list.Sort();

            foreach (var figure in list)
                figure.Print();

            var matrix = new SparseMatrix.Matrix<Figure>(3, 3, 3, null);
            matrix[0, 0, 0] = square;
            matrix[0, 1, 0] = rectangle;
            matrix[0, 0, 1] = circle;
            Console.WriteLine(matrix);

            var stack = new SimpleStack<Figure>();
            stack.Push(square);
            stack.Push(circle);
            stack.Push(rectangle);

            stack.Pop().Print();
            stack.Pop().Print();
            stack.Pop().Print();
        }
    }
}
