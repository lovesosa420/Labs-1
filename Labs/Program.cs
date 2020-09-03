using System;
using static System.Math;
using System.Collections.Generic;

namespace Lab1
{
    public static class Program
    {
        public static List<double> SolveBiQuadratic(double a, double b, double c)
        {
            var innerD = b * b - 4 * a * c;
            if (innerD < 0)
                return new List<double>();

            if (innerD == 0)
            {
                var outerD = -b / 2 * a;
                if (outerD < 0)
                    return new List<double>();

                if (outerD == 0)
                    return new List<double> { 0 };

                return new List<double>
                {
                    Sqrt(-b / 2 * a),
                    -Sqrt(-b / 2 * a),
                };
            }

            var D1 = (-b + Sqrt(innerD)) / (2 * a);
            var D2 = (-b - Sqrt(innerD)) / (2 * a);

            var ret = new List<double>();

            if (D1 == 0)
                ret.Add(0);
            else if (D1 > 0)
            {
                ret.Add(Sqrt(D1));
                ret.Add(-Sqrt(D1));
            }

            if (D2 == 0)
                ret.Add(0);
            else if (D2 > 0)
            {
                ret.Add(Sqrt(D2));
                ret.Add(Sqrt(D2));
            }

            return ret;
        }

        public static double GetVariable(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double ret))
                    return ret;

                Console.WriteLine("Введены неправильные данные");
            }
        }

        public static void WriteSolutions(double a, double b, double c)
        {
            var solutions = SolveBiQuadratic(a, b, c);
            if (solutions.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет корней");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < solutions.Count; i++)
                    Console.WriteLine($"X{i} = {solutions[i]}");
            }

            Console.ResetColor();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Кузнецов Г.И. ИУ5-33Б");

            if (args.Length == 0)
                while (true)
                {
                    double a;
                    while (true)
                    {
                        a = GetVariable("A = ");

                        if (a != 0)
                            break;

                        Console.WriteLine("A должен быть != 0");
                    }

                    var b = GetVariable("B = ");
                    var c = GetVariable("C = ");

                    WriteSolutions(a, b, c);
                }
            else
            {
                try
                {
                    var a = Convert.ToDouble(args[0]);
                    var b = Convert.ToDouble(args[1]);
                    var c = Convert.ToDouble(args[2]);

                    Console.WriteLine($"A = {a}\nB = {b}\nC = {c}");

                    WriteSolutions(a, b, c);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Параметры командной строки указаны неверно");
                }
            }
        }
    }
}
